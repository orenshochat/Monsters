using Monsters.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Monsters.Service.BL
{
    //Todo - replace with auto mapper
    public class PrimitiveMapperHelper
    {
        public static Monsters.View.Models.Door Map(Monsters.DAL.Models.Door dalDoor)
        {
            return new View.Models.Door()
            {
                Id = dalDoor.Id,
                Power = dalDoor.Power,
                KidBehindDoorName = dalDoor.KidBehindDoorName
            };
        }

        public static Monsters.View.Models.Scare Map(Monsters.DAL.Models.Scare dalScare)
        {
            return new View.Models.Scare()
            {
                Id = dalScare.Id,
                Door = Map(dalScare.Door),
                ScareBegin = dalScare.ScareBegin,
                ScareEnded = dalScare.ScareEnded
            };
        }

        public static Monster Map(IEnumerable<Claim> claims)
        {
            string username = claims.FirstOrDefault(c => c.Type == "user_name").Value;
            string name = claims.FirstOrDefault(c => c.Type == "name").Value;
            string startedScaring = claims.FirstOrDefault(c => c.Type == "started_scaring").Value;
            

            return new Monster()
            {
                Id = username,
                Name = name,
                StartedScaring = DateTime.Parse(startedScaring)
            };
        }
    }
}
