using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monsters.DAL.Models
{
    public class Scare
    {
        [StringLength(50)]
        public string Id { get; set; }
        public DateTime ScareBegin { get; set; }
        public DateTime ScareEnded { get; set; }

        [StringLength(50)]
        public string MonsterId { get; set; }

        public Door Door { get; set; }
    }
}
