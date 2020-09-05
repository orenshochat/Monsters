using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monsters.View.Models
{
    public class EndScareRequest
    {
        [Required(ErrorMessage = "{0} is required")]
        public string ScareId { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this).ToString();
        }

    }
}
