using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monsters.View.Models
{
    public class Scare
    {
        public string Id { get; set; }
        public DateTime ScareBegin { get; set; }
        public DateTime ScareEnded { get; set; }

        public int MonsterId { get; set; }

        public Door Door { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this).ToString();
        }

    }
}
