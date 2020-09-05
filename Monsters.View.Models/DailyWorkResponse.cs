using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monsters.View.Models
{
    public class DailyWork
    {
        public DateTime Date { get; set; }
        public List<Monsters.View.Models.Door> DepletedDoors { get; set; }
        public bool FilledQuota { get; set; }
    }

    public class DailyWorkResponse
    {

        public List<DailyWork> DailyWork { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this).ToString();
        }

    }
}
