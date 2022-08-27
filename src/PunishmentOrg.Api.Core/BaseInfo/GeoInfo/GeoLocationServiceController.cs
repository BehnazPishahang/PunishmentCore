
using Anu.BaseInfo.ServiceModel.GeoInfo;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations.BaseInfo.GeoInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utility;

namespace Anu.BaseInfo.Api.GeoInfo
{
    public class GeoLocationServiceController : GeoLocationServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor
        public GeoLocationServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides
        [AllowAnonymous]
        public override async Task<GeoLocationResponse> GetGeoLocationList([FromBody] GeoLocationRequest request)
        {

            #region Validation
            if (IsRequestEmpty(request))
            {
                return this.Respond(GeoLocationResult.GeoLocation_Request_IsNull);
            }

            if (this.IsRequestValid(request))
            {
                return this.Respond(GeoLocationResult.GeoLocation_Request_IsNull);
            }
            #endregion Validation

           
            var ListGeoLocation = await _unitOfWork.Repositorey<Anu.BaseInfo.DataAccess.GeoInfo.GeoLocationRepository>()
                .GetGeoLocationListWithParentLocationCode(request.TheGeoLocationContract!.LocationCode, (Anu.BaseInfo.Enumerations.LocationType)request.TheGeoLocationContract.ChildLocationType!);

            var ListGeoLocationContract = this.GetListGeoLocationContract(ListGeoLocation);
            return this.Respond(Anu.Commons.ServiceModel.ServiceResponseEnumerations.AnuResult.Successful, ListGeoLocationContract);
        }
        #endregion Overrides

        #region Methods
        private bool IsRequestEmpty(GeoLocationRequest request)
        {
            return request is null || request.TheGeoLocationContract is null;
        }

        private bool IsRequestValid(GeoLocationRequest request)
        {
            return request.TheGeoLocationContract?.LocationCode is null || request.TheGeoLocationContract.ChildLocationType == Enumerations.LocationType.None;
        }

        private GeoLocationResponse Respond(GeoLocationResult result)
        {
            var response = new GeoLocationResponse() 
            {
                Result = result.GetResult()
            };
            return response;
        }

        private GeoLocationResponse Respond(Anu.Commons.ServiceModel.ServiceResponseEnumerations.AnuResult result, List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract> GeoLocationList)
        {
            var response = new GeoLocationResponse()
            {
                Result = result.GetResult(),
                TheGeoLocationContractList = GeoLocationList
            };
            return response;
        }

        private List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract> GetListGeoLocationContract(IEnumerable<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation> geoLocationList)
        {
            List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract> geoLocationContracts = new List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract>();
            foreach (var geoLocation in geoLocationList.ToList())
            {
                geoLocationContracts.Add(new GeoLocationContract() { LocationName = geoLocation.LocationName, LocationCode = geoLocation.LocationCode });
            }

            return geoLocationContracts;

        }
        #endregion Methods
    }
}