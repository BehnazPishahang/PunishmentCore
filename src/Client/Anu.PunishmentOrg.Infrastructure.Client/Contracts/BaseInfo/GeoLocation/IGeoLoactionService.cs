using Anu.BaseInfo.ServiceModel.GeoInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Infrastructure.Contracts.BaseInfo.GeoLocation
{
    public  interface IGeoLoactionService
    {

        public List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract> GetProvicesList(string baseURl, string serviceName, GeoLocationRequest request);
        public List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract> GetCitiesList(string baseURl, string serviceName, GeoLocationRequest request);

    }
}
