using Anu.Commons.ServiceModel.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class FirstStepAuthResult : IResponseMessage
    {
        public int SecondsWait { get; set; }

        public int CountCharacter { get; set; }

        public Result Result { get; set; }
    }
}
