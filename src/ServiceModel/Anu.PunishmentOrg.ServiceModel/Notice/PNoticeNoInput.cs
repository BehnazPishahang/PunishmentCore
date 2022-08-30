using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    public class PNoticeNoInput
    {
        public PNoticeNoInput()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }
    }
}
