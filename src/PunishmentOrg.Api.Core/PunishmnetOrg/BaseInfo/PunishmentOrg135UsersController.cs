using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Domain;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.ServiceModel.BaseInfo;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.PunishmnetOrg.BaseInfo
{
    public class PunishmentOrg135UsersController : PunishmentOrg135UsersControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;
        public PunishmentOrg135UsersController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<PunishmentOrg135UsersResponse> GetProfile([FromBody] PunishmentOrg135UsersRequest request)
        {
            request.Null(AnuResult.Request_Is_Not_Valid);

            request.PunishmentOrg135UsersInputContract.NationalCode.NullOrWhiteSpace(AnuResult.NationalCode_Is_Not_Entered);

            request.PunishmentOrg135UsersInputContract.NationalCode.IsValidNationalCode();

            var punishmentOrg135Users = (await _unitOfWork.Repositorey<IGenericRepository<PunishmentOrg135Users>>().Find(a => a.NationalityCode == request.PunishmentOrg135UsersInputContract.NationalCode)).SingleOrDefault();
            punishmentOrg135Users.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            var user = new PunishmentOrg135UsersContract()
            {
                NationalCode = punishmentOrg135Users.NationalityCode,
                BirthDate = punishmentOrg135Users.FatherName,
                FirstName = punishmentOrg135Users.Name,
                LastName = punishmentOrg135Users.Family,
                PhoneNumber = punishmentOrg135Users.MobileNumber4SMS,
                Sex = (Anu.BaseInfo.Enumerations.SexType)punishmentOrg135Users.Sex
            };

            return new PunishmentOrg135UsersResponse() { Result = AnuResult.Successful.GetResult(), PunishmentOrg135UsersContract = user };
        }
    }
}
