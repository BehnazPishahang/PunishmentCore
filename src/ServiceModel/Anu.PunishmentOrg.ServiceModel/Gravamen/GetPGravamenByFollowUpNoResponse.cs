using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    public class GetPGravamenByIdResponse
    {
        public PGravamenContract ThePGravamenContract { get; set; }
    }
}