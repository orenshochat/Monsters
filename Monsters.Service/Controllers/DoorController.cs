using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Logging;
using Monsters.Service.BL;
using Monsters.Service.Models;
using Monsters.View.Models;

namespace Monsters.Service.Controllers
{
    [ApiController]
    [Route("doors")]
    [Authorize]
    public class DoorController : ControllerBase
    {
        private readonly IMonsterApi _api; 
      

        private readonly ILogger<DoorController> _logger;

        public DoorController(IMonsterApi api, ILogger<DoorController> logger)
        {
            _api = api;
            _logger = logger;
        }

        [HttpGet]
        [Route("freedoors")]
        public async Task<IActionResult> GetAvailbleDoorsAsync()
        {
            if (ModelState.IsValid)
                return ProcessRequest<IEnumerable<Door>>(await _api.GetAvailbleDoorsAsync().ConfigureAwait(false));
            return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
        }


        [HttpPost]
        [Route("scare")]
        public async Task<IActionResult> CreateScare([FromBody] CreateScareRequest request)
        {
            if(ModelState.IsValid)
                return ProcessRequest<Scare>(await _api.CreateScareAsync(request, PrimitiveMapperHelper.Map(User.Claims)).ConfigureAwait(false));

            return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
        }

        [HttpPut]
        [Route("scare")]
        public async Task<IActionResult> EndScare([FromBody] EndScareRequest request)
        {
            if (ModelState.IsValid)
                return ProcessRequest<Scare>(await _api.EndScareAsync(request).ConfigureAwait(false));

            return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
        }


        [HttpGet]
        [Route("work")]
        public async Task<IActionResult> GetDailyWork(DateTime? dateFrom, DateTime? dateTo = null, bool filterByAccomplished = false)
        {
            var request = new DailyWorkRequest()
            {
                From = dateFrom.Value,
                To = dateTo.Value,
                FilterByAccomplishedGoal = filterByAccomplished
            };

            return ProcessRequest<DailyWorkResponse>(await _api.GetWorkAsync(request, PrimitiveMapperHelper.Map(User.Claims)).ConfigureAwait(false));
        }



        private IActionResult ProcessRequest<T>(BlTResult<T> result) where T : class
        {
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            else
            {
                switch (result.StatusCode)
                {
                    case StatusCodes.Status409Conflict:
                        return Conflict(result.ErrorMsg);
                    default:
                        return BadRequest(result.ErrorMsg);
                }
                
            }
        }

    }
}
