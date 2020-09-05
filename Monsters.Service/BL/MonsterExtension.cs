using Monsters.Service.Models;
using Monsters.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.BL
{
    public static class MonsterExtension
    {
        public static bool IsAccomplishedDailyGoal(this Monster monster, DailyWork dailyWork )
        {
            int monsterDailyQuota  = ((dailyWork.Date.Year - monster.StartedScaring.Year)) * 20 + 100;

            return dailyWork.DepletedDoors.Sum(d => d.Power) >= monsterDailyQuota; 

        }
    }
}
