using System;
using System.ComponentModel.DataAnnotations;

namespace Monsters.DAL.Models
{
    public class Door
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(20)]
        public string KidBehindDoorName { get; set; }
        public int Power { get; set; }

        [ConcurrencyCheck]
        public DateTime LastScare { get; set; }
    }
}
