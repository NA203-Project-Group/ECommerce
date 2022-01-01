using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult :Results.Result
    {
        public SuccessResult(string messages) : base(messages, true)
        {
        }

        public SuccessResult() : base(true)
        {
        }

    }
}
