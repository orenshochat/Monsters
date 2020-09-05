using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.Models
{
    public class BlTResult<T> : BlResult  where T : class
    {


        public T Data { get; set; }

        #region Ctors


        public BlTResult()
        {

        }
        public BlTResult(bool isSuccess) :base(isSuccess)
        {
            
        }

        public BlTResult(T data)
        {
            IsSuccess = true;
            StatusCode = StatusCodes.Status200OK;
            Data = data;
        }

        public BlTResult(bool isSuccess, T data): base(isSuccess)
        {
            Data = data;
        }

        public BlTResult(string errorMessage) 
        {
            ErrorMsg = errorMessage; 
        }

        public BlTResult(string format, params object[] args) 
        {
        }



        public BlTResult(T data, bool isSuccess, int statusCode, string errorMessage) 
        {
            Data = data;
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            ErrorMsg = errorMessage; 
        }

        #endregion Ctors
    }
}

