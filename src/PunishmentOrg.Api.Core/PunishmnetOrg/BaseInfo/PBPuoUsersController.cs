using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Authentication;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.ServiceModel.BaseInfo;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.PunishmnetOrg.BaseInfo
{
    public class PBPuoUsersController : PBPuoUsersControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;
        public PBPuoUsersController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)]
        public override async Task<PBPuoUsersResponse> GetProfile([FromBody] PBPuoUsersRequest request)
        {
            request.Null(AnuResult.Request_Is_Not_Valid);

            request.PBPuoUsersInputContract.NationalCode.NullOrWhiteSpace(AnuResult.NationalCode_Is_Not_Entered);

            request.PBPuoUsersInputContract.NationalCode.IsValidNationalCode();

            var pBPuoUsers = (await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsers>>().Find(a => a.NationalityCode == request.PBPuoUsersInputContract.NationalCode)).SingleOrDefault();
            pBPuoUsers.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            var user = new PBPuoUsersContract()
            {
                NationalCode = pBPuoUsers.NationalityCode,
                BirthDate = pBPuoUsers.FatherName,
                FirstName = pBPuoUsers.Name,
                LastName = pBPuoUsers.Family,
                PhoneNumber = pBPuoUsers.MobileNumber4SMS,
                Sex = (Anu.BaseInfo.Enumerations.SexType)pBPuoUsers.Sex
            };

            return new PBPuoUsersResponse() { Result = AnuResult.Successful.GetResult(), PBPuoUsersContract = user };
        }
    }
}
