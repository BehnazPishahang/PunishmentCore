using Anu.Commons.ServiceModel.ServiceResponse;

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
            result = ResultUtility.getResult(type);
        }
    }
}
