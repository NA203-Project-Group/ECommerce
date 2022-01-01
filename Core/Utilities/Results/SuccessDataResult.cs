using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;


namespace Core.Utilities.Results
{
   public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string messages) : base(data, messages, true)
        {
        }
        public SuccessDataResult(string messages) : base(default, messages, true)
        {
        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }

        public SuccessDataResult() : base(default, true)
        {
        }
        
    }
}
