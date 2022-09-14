﻿using Anu.Commons.ServiceModel.ServicePaging;

namespace Anu.PunishmentOrg.Api.Accounting
{
    public class GetPBill4PaidListByNationalCodeRequest : IPaging
    {
        public GetPBill4PaidListByNationalCodeRequest()
        {
            Page = new Page();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کدملی شخص دارای قبض در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidNationalCodeContract? ThePBill4PaidNationalCodeContract { get; set; }
        public Page Page { get; set; }
    }
}