using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Results.Result
    {
        public ErrorResult(string messages) : base(messages, false)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
