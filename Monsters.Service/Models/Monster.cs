using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.Models
{
    public class Monster
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime StartedScaring { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this).ToString();
        }
    }
}
