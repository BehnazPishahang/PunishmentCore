using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ApiSample.Helper
{
    public class HelperMethods
    {
        public string CreateRequestIdForShahkarService()
        {
            StringBuilder RequestId = new StringBuilder();
            RequestId.AppendFormat("{0}", "0644");
            RequestId.Append(DateTime.Now.ToString("yyyyMMddHHmmssffffff", CultureInfo.InvariantCulture));
            return RequestId.ToString();
        }
    }
}
