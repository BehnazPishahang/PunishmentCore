using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunishmentOrg.ServiceModels.ServiceContract.Anu.PunishmentOrg;

namespace PunishmentOrg.ServiceModels.ServiceResponse.Anu.PunishmentOrg;

public class SendBillOwnershipResponse : BillOwnershipOrganization, ResponseMessage.IResponseMessage
{
    public SendBillOwnershipResponse()
    {
        ResponseMessage = new ResponseMessage(); 
    }

    public ResponseMessage ResponseMessage { get; set; }
}