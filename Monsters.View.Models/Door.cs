using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Monsters.View.Models
{
    public class Door
    {
        public string Id { get; set; }
        public string KidBehindDoorName { get; set; }
        
        public int Power { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this).ToString();
        }
    }
}
