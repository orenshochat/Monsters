using Monsters.DAL.Models;
using Monsters.Service.Models;
using Monsters.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.BL
{
    public interface IMonsterApi
    {
        Task<BlTResult<IEnumerable<View.Models.Door>>> GetAvailbleDoorsAsync();
        Task<BlTResult<View.Models.Scare>> CreateScareAsync(CreateScareRequest request, Monster monster);

        Task<BlTResult<View.Models.Scare>> EndScareAsync(EndScareRequest request);


        /// <summary>
        /// Get the scares performed by the monster filtered by date range and accomplished daily goal
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        Task<BlTResult<DailyWorkResponse>> GetWorkAsync(DailyWorkRequest request, Monster monster);




    }
}
