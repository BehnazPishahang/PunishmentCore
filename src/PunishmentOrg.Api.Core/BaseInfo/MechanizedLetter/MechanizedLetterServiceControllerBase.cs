﻿using Anu.BaseInfo.ServiceModel.MechanizedLetter;

namespace Anu.PunishmentOrg.Api.BaseInfo.MechanizedLetter
{
    public abstract class MechanizedLetterServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public MechanizedLetterServiceControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v2/SendMechanizedLetter")]
        public abstract Task<MechanizedLetterResponse> SendMechanizedLetter([Microsoft.AspNetCore.Mvc.FromBody] MechanizedLetterRequest request);

    }
}
