using Microsoft.AspNetCore.Mvc;
using PunishmentOrg.Api.Core.ServiceBase.Anu.PunishmentOrg;

namespace PunishmentOrg.Api.Core.Service.Anu.PunishmentOrg;

[ApiController]
[Route("[controller]")]
public class BillOwnershipOrganizationServicesController : ControllerBase, IBillOwnershipOrganizationServicesBase
{
    [HttpGet(Name = "SendBillOwnership")]
    public void SendBillOwnership()
    {
        throw new NotImplementedException();
    }

    [HttpGet(Name = "ReceiveBillOwnership")]
    public void ReceiveBillOwnership()
    {
        throw new NotImplementedException();
    }
}