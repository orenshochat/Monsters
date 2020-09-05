using Monsters.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.BL
{
    public interface IMonsterRepository
    {
        Task<Door> GetDoorAsync(string doorId);
        Task<IEnumerable<Door>> GetDoorsAsync(DateTime from, DateTime to);
        Task<Monsters.DAL.Models.Door> UpdateDoorAsync(Monsters.DAL.Models.Door door);
        Task<Scare> CreateScareAsync(Scare scare);
        Task<Scare> UpdateScareAsync(string scareId, DateTime scareEnded);
        Task<IEnumerable<Scare>> GetScaresByDateAsync(DateTime from, DateTime to, string monsterId);

    }
}
