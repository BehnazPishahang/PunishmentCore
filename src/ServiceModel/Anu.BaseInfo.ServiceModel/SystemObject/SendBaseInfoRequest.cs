
namespace Anu.BaseInfo.ServiceModel.SystemObject
{
    [System.ComponentModel.DisplayName("SendBaseInfoRequest")]
    public class SendBaseInfoRequest
    {
        public SendBaseInfoRequest()
        {
        }
            
            [System.ComponentModel.DisplayName("اقلام سرویس اطلاعات پایه در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemObject.BaseInfoServiceContract? TheBaseInfoServiceContract { get; set; }

            

    }
    }
