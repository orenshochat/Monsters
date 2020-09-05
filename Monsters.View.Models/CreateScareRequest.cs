using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Monsters.View.Models
{
    public class CreateScareRequest
    {
        [Required]
        public string DoorId { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this).ToString();
        }
    }
}
