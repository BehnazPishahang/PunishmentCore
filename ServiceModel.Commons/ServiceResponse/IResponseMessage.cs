using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel.Commons.ServiceResponse
{
    public interface IResponseMessage
    {
        Result Result { get; set; }
    }

    public class ResponseMessage : IResponseMessage
    {
        public ResponseMessage()
        {
            this.Result = new Result();
        }
        public Result Result { get; set; }
    }

    public interface IResult
    {
        string Message { get; set; }
        string Code { get; set; }
    }

    public class Result : IResult
    {
        public Result()
        {
            this.Message = "";
            this.Code = "";
        }
        public string Message { get; set; }
        public string Code { get; set; }
    }
}
