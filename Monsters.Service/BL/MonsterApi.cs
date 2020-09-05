using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Monsters.DAL.Models;
using Monsters.Service.Models;
using Monsters.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.BL
{

    public class MonsterApi : IMonsterApi
    {
        private readonly IMonsterRepository _repository;
        private readonly ILogger<MonsterApi> _logger;
        public MonsterApi(IMonsterRepository repository, ILogger<MonsterApi> logger)
        {
            _repository = repository;
            _logger = logger;

        }
        public async Task<BlTResult<View.Models.Scare>> CreateScareAsync(CreateScareRequest request, Monster monster)
        {
            Monsters.DAL.Models.Door door = await _repository.GetDoorAsync(request.DoorId).ConfigureAwait(false);

            if(door == null)
            {
                string errorMsg = $"Create scare failed. Door doesnt exist. Request: {request.ToString()} Monster: {monster.ToString()} ";
                _logger.LogError(errorMsg);
                return new BlTResult<View.Models.Scare>()
                {
                    IsSuccess = false,
                    ErrorMsg = errorMsg,
                    StatusCode = StatusCodes.Status400BadRequest

                };

            }

            if (door.LastScare.Date >= DateTime.Today.Date)
            {
                
                string errorMsg = $"Create scare failed. Door already in use today by someone. Request: {request.ToString()} Monster: {monster.ToString()} ";
                _logger.LogError(errorMsg);
                return new BlTResult<View.Models.Scare>()
                {
                    IsSuccess = false,
                    ErrorMsg = errorMsg,
                    StatusCode = StatusCodes.Status409Conflict

                };
            }

            try
            {
                door.LastScare = DateTime.Today;
                var updateResult = await _repository.UpdateDoorAsync(door).ConfigureAwait(false);
                Monsters.DAL.Models.Scare createResult = await _repository.CreateScareAsync(
                    new Monsters.DAL.Models.Scare() { Id = Guid.NewGuid().ToString(), Door = door, MonsterId = monster.Id, ScareBegin = DateTime.Now }).ConfigureAwait(false);

                return new BlTResult<View.Models.Scare>()
                {
                    IsSuccess = true,
                    Data = PrimitiveMapperHelper.Map(createResult) 
                };
            }
            catch (Exception ex)
            {
                string errorMsg = $"Create scare failed. Request: {request.ToString()}. Monster: {monster.ToString()}. Error: {ex.ToString()}";
                _logger.LogError(errorMsg);
                return new BlTResult<View.Models.Scare>()
                {
                    IsSuccess = false,
                    ErrorMsg = errorMsg,
                    StatusCode = StatusCodes.Status400BadRequest

                };
            }
        }

        public async Task<BlTResult<View.Models.Scare>> EndScareAsync(EndScareRequest request)
        {
            try
            {
                Monsters.DAL.Models.Scare scare = await _repository.UpdateScareAsync(request.ScareId, DateTime.Now);
                return new BlTResult<View.Models.Scare>() {IsSuccess = true, Data =  PrimitiveMapperHelper.Map(scare) };

            }
            catch (Exception ex)
            {
                string errorMsg = $"Error ending scare. Request: {request.ToString()} Error: {ex.ToString()}"; 
                _logger.LogError(errorMsg);
                return new BlTResult<View.Models.Scare>() {IsSuccess = false, ErrorMsg = $"errorMsg" };
            }
        }

        public async Task<BlTResult<DailyWorkResponse>> GetWorkAsync(DailyWorkRequest request, Monster monster)
        {
            try
            {

                IEnumerable<Monsters.DAL.Models.Scare> response = await _repository.GetScaresByDateAsync(request.From, request.To, monster.Id).ConfigureAwait(false);
                if (response.Count() == 0 )
                {
                    string msg = $"No work found;";
                    return new BlTResult<DailyWorkResponse>() { IsSuccess = false, ErrorMsg = msg };
                }

                var dailyWorkResponse = new DailyWorkResponse()
                {
                    DailyWork = new List<DailyWork>() 
                };


                DailyWork dailyWork = new DailyWork()
                {
                    Date = response.First().ScareBegin.Date,
                    DepletedDoors = new List<View.Models.Door>() 
                   
                };

                foreach (Monsters.DAL.Models.Scare scare in response)
                {
                    //if we moved to the next day 
                    //Wrap the prev day and add it to result
                    if (scare.ScareBegin.Date != dailyWork.Date)
                    {

                        dailyWork.FilledQuota = monster.IsAccomplishedDailyGoal(dailyWork);
                        //Add the day to response if we dont filter by accomplish
                        //or if we do filter by accomplish and the monster accomplished his daily quota that day
                        if (!request.FilterByAccomplishedGoal || dailyWork.FilledQuota)
                            dailyWorkResponse.DailyWork.Add(dailyWork); 

                        //Start new day
                        dailyWork = new DailyWork()
                        {
                            Date = scare.ScareBegin.Date,
                            DepletedDoors = new List<View.Models.Door>()

                        };
                    }
                    //add the scare to the day
                    dailyWork.DepletedDoors.Add(PrimitiveMapperHelper.Map(scare.Door));
                    
                }

                return new BlTResult<DailyWorkResponse>() { IsSuccess = true, Data = dailyWorkResponse };

            }
            catch (Exception ex)
            {
                string errorMsg = $"Exception thrown trying to get daily work. Error {ex.ToString()}.";
                _logger.LogError(errorMsg);
                return new BlTResult<DailyWorkResponse>() { IsSuccess = false, ErrorMsg = errorMsg }; 
            }
            

        }

        public async Task<BlTResult<IEnumerable<View.Models.Door>>> GetAvailbleDoorsAsync()
        {
            try
            {
                IEnumerable<Monsters.DAL.Models.Door> dalResult = await _repository.GetDoorsAsync(DateTime.MinValue, DateTime.Today).ConfigureAwait(false);
                IEnumerable<View.Models.Door> viewModelresult = dalResult?.Select(door => PrimitiveMapperHelper.Map(door));
                return new BlTResult<IEnumerable<View.Models.Door>>()
                {
                    IsSuccess = true,
                    StatusCode = StatusCodes.Status200OK,
                    Data = viewModelresult
                };
            }
            catch (Exception e)
            {
                string errorMsg = $"Getting availble doors threw an exception. Exception:{e.ToString()}";
                return new BlTResult<IEnumerable<View.Models.Door>>()
                {
                    IsSuccess = false,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    ErrorMsg = errorMsg
                };
            }
        }
    }
                    
}

    