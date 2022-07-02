using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.ServiceResponse
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
        string Description { get; set; }
        string Code { get; set; }
    }

    public class Result : IResult
    {
        public Result()
        {
            this.Message = "";
            this.Description = "";
            this.Code = "";
        }
        public string Message { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
