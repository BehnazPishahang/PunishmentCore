using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel.Commons.ServiceRequest
{
    public interface IRequestMessage
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام کاربري")]
        string UserName { get; set; }

        [System.ComponentModel.DisplayName("کلمه عبور")]
        string PassWord { get; set; }
    }


    public class RequestMessage : IRequestMessage
    {
        public RequestMessage()
        {
            this.UserName = "";
            this.PassWord = "";
        }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
