using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Infrastructure.Utitlities
{
    public static class PDFconvertor
    {
       
        public static string ConvertToPdfContent(string input)
        {
            byte[] content = Convert.FromBase64String(input);
            return $"data:application/pdf;base64,{Convert.ToBase64String(content)}";
          
        }
    }
}
