using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.Models
{
    public class BlResult
    {
        public BlResult()
        {

        }
        public BlResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public bool IsSuccess { get; set; }
        public string ErrorMsg { get; set; }

        public int StatusCode { get; set; }

    }
}
