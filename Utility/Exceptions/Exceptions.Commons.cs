using ServiceModel.Commons.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Exceptions
{
    
    public class AnuExceptions : Exception
    {
        public Result result { get; set; }

        public AnuExceptions() { }

        public AnuExceptions(string message)
            : base(message) { }

        public AnuExceptions(string message, Exception inner)
            : base(message, inner) { }
        public AnuExceptions(ResultType type) 
        {
            result = ServiceResultUtilities.getResult(type);
        }
    }
}
