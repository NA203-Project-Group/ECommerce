using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Core.Utilities.Results
{
   public class Result : IResult
    {
        public Result(string messages,bool success):this(success)
        {
            Messages = messages;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Messages { get; }
    }
}
