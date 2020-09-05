using Microsoft.EntityFrameworkCore;
using Monsters.DAL.Models;
using Monsters.Service.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.BL
{
    public class MonsterRepositoryEF : IMonsterRepository
    {
        public MonsterDbContext Context { get; set; }

        public MonsterRepositoryEF()
        {
            Context = new MonsterDbContext(); 
        }
         
        public async Task<Monsters.DAL.Models.Door> GetDoorAsync(string doorId)
        {
            return await Context.Doors.FirstOrDefaultAsync(door => door.Id == doorId).ConfigureAwait(false); 

        }

        public async Task<Monsters.DAL.Models.Door> UpdateDoorAsync(Monsters.DAL.Models.Door door)
        {
               
            if(door != null)
            {
                Context.Doors.Update(door);
                await Context.SaveChangesAsync();
                return door;

            }

            return null;
        }

        public async Task<IEnumerable<Monsters.DAL.Models.Door>> GetDoorsAsync(DateTime from, DateTime to)
        {
            return await Context.Doors.Where((door => door.LastScare.Date > from.Date && door.LastScare.Date <= to.Date )).ToArrayAsync().ConfigureAwait(false);
        }

        public async Task<Scare> CreateScareAsync(Scare scare)
        {
            try
            {
                Context.Scares.Add(scare);
                int result = await Context.SaveChangesAsync().ConfigureAwait(false);
                return scare;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<Scare> UpdateScareAsync(string scareId, DateTime scareEnded)
        {
                var scare = await Context.Scares.FirstOrDefaultAsync(sc => sc.Id == scareId).ConfigureAwait(false);
                if (scare != null)
                    scare.ScareEnded = scareEnded; 

                await Context.SaveChangesAsync().ConfigureAwait(false);
                return scare;
        }

        public async Task<IEnumerable<Scare>> GetScaresByDateAsync(DateTime from, DateTime to, string monsterId)
        {

            Scare[] query = await Context.Scares
                .Where(sc => sc.ScareBegin.Date >= from.Date &&
                        sc.ScareEnded != null &&
                        sc.ScareEnded.Date <= to.Date &&
                        sc.MonsterId == monsterId).OrderBy(sc => sc.ScareBegin.Date).ToArrayAsync(); 


            return query;
        }

    }
}
