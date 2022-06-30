using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.SeviceRequest
{
    public interface IRequestMessage
    {
        Request Request { get; set; }
    }


    public class RequestMessage : IRequestMessage
    {
        public RequestMessage()
        {
            this.Request = new Request();
        }
        public Request Request { get; set; }
    }

    public interface IRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام کاربري")]
        string UserName { get; set; }

        [System.ComponentModel.DisplayName("کلمه عبور")]
        string PassWord { get; set; }
    }

    public class Request : IRequest
    {
        public Request()
        {
            this.UserName = "";
            this.PassWord = "";
        }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
