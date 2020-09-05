using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monsters.View.Models
{
    public class DailyWorkRequest
    {
        [Required(ErrorMessage = "From is required")]
        public DateTime From { get; set; }

        [Required(ErrorMessage = "To is required")]
        public DateTime To { get; set; }

        public bool FilterByAccomplishedGoal { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this).ToString();
        }

    }
}
