
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.BaseInfo.ServiceModel.SystemObject
{
    [System.ComponentModel.DisplayName("SendBaseInfoResponse")]
    public class SendBaseInfoResponse
    {
        public Result Result { get; set; }

        public SendBaseInfoResponse()
        {
            Result = new Result();
        }

            [System.ComponentModel.DisplayName("اقلام سرویس اطلاعات پایه در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemObject.BaseInfoServiceContract? TheBaseInfoServiceContract { get; set; }

            

    }
    }
