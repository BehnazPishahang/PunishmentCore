﻿namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class GetAllPCaseInputContract
    {
        public GetAllPCaseInputContract()
        {
        }
        public string? NationalCode { get; set; }
        public Enumerations.PUCaseArchiveState CaseArchiveState { get; set; }
    }
}
