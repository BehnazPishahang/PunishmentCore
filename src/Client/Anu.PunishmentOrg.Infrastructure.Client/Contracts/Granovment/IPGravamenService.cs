using Anu.PunishmentOrg.ServiceModel.Gravamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Infrastructure.Contracts.Granovment
{
    public interface IPGravamenService
    {
        public  PGravamenServiceResponse RecieveGravamen(String baseURl, string serviceName, PGravamenServiceRequest request);

        public GetPGravamenByIdResponse GetGravamenByFollowingNo(String baseURl, string serviceName, GetPGravamenByIdRequest request);

        public IEnumerable<PGravamenInfoContract> GetGravamenListByNationalNo(String baseURl, string serviceName, string nationalCode,string accessToken);

        public Task<GetPersonPGravamenStatisticContract> GetPersonPGravamenStatistic(String baseURl, string serviceName, string nationalCode, string accessToken);

    }
}
