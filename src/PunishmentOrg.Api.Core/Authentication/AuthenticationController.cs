using Anu.BaseInfo.DataAccess.FrontEndSecurity;
using Anu.BaseInfo.DataModel.ExchangeData;
using Anu.BaseInfo.DataModel.FrontEndSecurity;
using Anu.BaseInfo.Domain.ExchangeData;
using Anu.BaseInfo.Domain.FrontEndSecurity;
using Anu.Commons.ServiceModel.ServiceAuthentication;
using Anu.Commons.ServiceModel.ServiceAuthentication.Enumerations;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.DataAccess;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Authentication.Utility;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Utility;
using Utility.CalendarHelper;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Authentication
{
    public class AuthenticationController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly int _SecodeWait = 120;
        private readonly int _CountCharacter = 6;
        private readonly int _LimitSendDayCodePerDay = 20;
        private readonly string _NotVerify = "|NotVerify";


        public AuthenticationController(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }

        #region OldLogin

        [Route("api/v1/Login")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<FirstStepAuthResult> Login([FromBody] FirstStepUserLoginRequest request)
        {
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();

            var theGFESUser = (await _unitOfWork.Repositorey<IGenericRepository<GFESUser>>()
                .Find(x => x.NationalityCode == request.UserName)).FirstOrDefault();

            theGFESUser.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            string password = await theGFESUser.MobileNumber4SMS.SendAuthenticateSms(_CountCharacter);
            string passWordHash = MD5Core.GetHashString(password);

            theGFESUser.Password = passWordHash;
            theGFESUser.LastChangePassword = DateTime.Now.AddSeconds(_SecodeWait).ToString("MM/dd HH:mm:ss");

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }

            return new FirstStepAuthResult() { CountCharacter = _CountCharacter, SecondsWait = _SecodeWait, Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args: theGFESUser.MobileNumber4SMS.Substring(theGFESUser.MobileNumber4SMS.Length - 4) + "*****09") };

        }

        [Route("api/v1/Register")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<FirstStepAuthResult> Register([FromBody] UserRegisterRequest request)
        {
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
            request.PhoneNumber.NullOrWhiteSpace(AnuResult.PhoneNumber_Is_Not_Entered);

            request.UserName.IsValidNationalCode();
            request.PhoneNumber.IsValidPhone();

            if (await _unitOfWork.Repositorey<IGenericRepository<GFESUser>>().Exist(a => a.UserID == request.UserName))
            {
                return new FirstStepAuthResult() { Result = AnuResult.User_Is_Exist.GetResult() };
            }
            
            await ShahkarAuthentication.ShahkarAuthenticate(request.PhoneNumber, request.UserName);
            await SabteahvalAuthentication.SabteahvalAuthenticate(request);


            string password = await request.PhoneNumber.SendAuthenticateSms(_CountCharacter);
            string passWordHash = MD5Core.GetHashString(password);

            var user = new GFESUser()
            {
                Id = System.Guid.NewGuid().ToString("N"),
                UserID = request.UserName,
                Password = passWordHash,
                MobileNumber4SMS = request.PhoneNumber,
                NationalityCode = request.UserName,
                StartDate = CalendarHelper.GetCurrentDateTime(),
                EndDate = CalendarHelper.MaxDateTime(),
                Family = request.LastName,
                FatherName = "b",
                LastChangePassword = DateTime.Now.AddSeconds(_SecodeWait).ToString("MM/dd HH:mm:ss"),
                Name = request.FirstName,
                Sex = request.Sex
            };

            await _unitOfWork.Repositorey<IGenericRepository<GFESUser>>().Add(user);

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }


            //var theGFESUser = await _unitOfWork.Repositorey<GFESUserRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, password);
            //theGFESUser.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            //var jwtToken = GenerateJwtToken(theGFESUser);

            //insert password code and date time into table

            return new FirstStepAuthResult() { CountCharacter = _CountCharacter, SecondsWait = _SecodeWait, Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args: request.PhoneNumber.Substring(request.PhoneNumber.Length - 4) + "*****09") };

        }

        [Route("api/v1/SecondStepLogin")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<AuthResult> SecondStepLogin([FromBody] SecondStepUserLoginRequest request)
        {

            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
            request.Password.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();


            var theGFESUser = await _unitOfWork.Repositorey<IGFESUserRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, request.Password);
            theGFESUser.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);


            switch (request.LoginType)
            {
                case LoginType.LoginWithSms:
                    if (("2022/" + theGFESUser.LastChangePassword).ToDateTime() < DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss").ToDateTime())
                    {
                        throw new AnuExceptions(AnuResult.Sms_Time_Is_Expired);
                    }
                    break;
            }

            var jwtToken = GenerateJwtToken(theGFESUser);

            return new AuthResult() { AccessToken = jwtToken, Result = AnuResult.Successful.GetResult() };

        }

        #endregion

        [Route("api/v1/SendSmsAuth")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<FirstStepAuthResult> SendSmsAuth([FromBody] FirstStepUserLoginRequest request)
        {
            #region ValidateInput
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();
            #endregion

            #region ValidateUserHistory
            var pBPuoUsers = (await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsers>>()
                .Find(x => x.NationalityCode == request.UserName)).FirstOrDefault();
            pBPuoUsers.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            var lastRecordHistoryPerDay = await _unitOfWork.Repositorey<IPBPuoUsersHistoryRepository>().LastRecordHistoryPerDay(pBPuoUsers.Id, DateTime.Now.DateToString());

            if (lastRecordHistoryPerDay != null && !Anu.Utility.Utility.IsDevelopment())
            {
                var difDateSecond = (DateTime.Now - lastRecordHistoryPerDay.SendCodeDateTime.ToDateTime()).TotalSeconds;
                if (difDateSecond < _SecodeWait && lastRecordHistoryPerDay.SendCodeDateTime != lastRecordHistoryPerDay.ExpiredCodeDateTime)
                {
                    return new FirstStepAuthResult() { Result = AnuResult.Send_Login_Request_After_x_Second.GetResult(args: ((int)(_SecodeWait - difDateSecond)).ToString()) };
                }

                if (lastRecordHistoryPerDay.CountCodePerDay >= _LimitSendDayCodePerDay)
                {
                    return new FirstStepAuthResult() { Result = AnuResult.Sms_Limit_Send.GetResult() };
                }
            }
            #endregion

            #region SendAndSubmitPassword
            string password = await pBPuoUsers.MobileNumber4SMS.SendAuthenticateSms(_CountCharacter);
            string passWordHash = MD5Core.GetHashString(password);

            pBPuoUsers.DynomicPassword = passWordHash;
            _unitOfWork.Repositorey<IPBPuoUsersRepository>().UpdateParent(pBPuoUsers);

            var currentDateTime = DateTime.Now;
            var userHistory = new PBPuoUsersHistory()
            {
                Id = Guid.NewGuid().ToString("N"),
                DynomicPassword = passWordHash,
                SendCodeDateTime = currentDateTime.DateTimeToString(),
                ExpiredCodeDateTime = currentDateTime.AddSeconds(_SecodeWait).DateTimeToString(),
                CountCodePerDay = lastRecordHistoryPerDay == null ? 1 : lastRecordHistoryPerDay.CountCodePerDay + 1,
                ThePBPuoUsers = pBPuoUsers
            };
            await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsersHistory>>().Add(userHistory);

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }
            #endregion

            return new FirstStepAuthResult()
            {
                CountCharacter = _CountCharacter,
                SecondsWait = _SecodeWait,
                Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args: pBPuoUsers.MobileNumber4SMS.Substring(pBPuoUsers.MobileNumber4SMS.Length - 4) + "*****09")
            };

        }

        [Route("api/v2/Register")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<FirstStepAuthResult> V2Register([FromBody] UserRegisterRequest request)
        {
            #region ValidateInput
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.NationalCode_Is_Not_Entered);
            request.PhoneNumber.NullOrWhiteSpace(AnuResult.PhoneNumber_Is_Not_Entered);
            request.FirstName.NullOrWhiteSpace(AnuResult.FirstName_Is_Not_Entered);
            request.LastName.NullOrWhiteSpace(AnuResult.LastName_Is_Not_Entered);

            request.BirthDate.NullOrWhiteSpace(AnuResult.BirthDate_Is_Not_Entered);
            request.BirthDate.IsValidDate(AnuResult.BirthDate_Is_Not_Valid);

            if (request.Sex != Anu.BaseInfo.Enumerations.SexType.Female && request.Sex != Anu.BaseInfo.Enumerations.SexType.Male)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Sex_Is_Not_Valid.GetResult() };
            }

            request.UserName.IsValidNationalCode();
            request.PhoneNumber.IsValidPhone();
            #endregion

            #region ExistingUser
            var pBPuoUsers = (await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsers>>().Find(a => a.UserID == request.UserName)).FirstOrDefault();

            if (pBPuoUsers != null)
            {
                if (pBPuoUsers.SendDynomicPassword.NullOrEmpty())
                {
                    return new FirstStepAuthResult() { Result = AnuResult.User_Is_Exist.GetResult() };
                }
                else
                {
                    await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsersHistory>>().RemoveRange(
                        await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsersHistory>>().Find(a => a.ThePBPuoUsers.Id == pBPuoUsers.Id)
                        );

                    await _unitOfWork.Repositorey<IGenericRepository<GFESUserAccess>>().Remove(
                        (await _unitOfWork.Repositorey<IGenericRepository<GFESUserAccess>>().Find(a => a.TheGFESUser.Id == pBPuoUsers.Id)).FirstOrDefault()
                        );

                    await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsers>>().Remove(
                        (await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsers>>().Find(a => a.Id == pBPuoUsers.Id)).FirstOrDefault()
                        );

                    await _unitOfWork.Repositorey<IGenericRepository<GFESUser>>().Remove(
                        (await _unitOfWork.Repositorey<IGenericRepository<GFESUser>>().Find(a => a.Id == pBPuoUsers.Id)).FirstOrDefault()
                        );

                    if (_unitOfWork.Complete() < 0)
                    {
                        return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
                    }
                }
            }
            #endregion

            #region ValidateShahkarAndSabteHval
            await ShahkarAuthentication.ShahkarAuthenticate(request.PhoneNumber, request.UserName);
            await SabteahvalAuthentication.SabteahvalAuthenticate(request);
            #endregion

            #region Register
            string password = await request.PhoneNumber.SendAuthenticateSms(_CountCharacter);
            string passWordHash = MD5Core.GetHashString(password);

            var user = new PBPuoUsers()
            {
                Id = System.Guid.NewGuid().ToString("N"),
                UserID = request.UserName,
                Password = passWordHash,
                DynomicPassword = passWordHash,
                SendDynomicPassword = _NotVerify,
                MobileNumber4SMS = request.PhoneNumber,
                NationalityCode = request.UserName,
                StartDate = CalendarHelper.GetCurrentDateTime(),
                EndDate = CalendarHelper.MaxDateTime(),
                Family = request.LastName,
                FatherName = request.BirthDate,
                BirthDay = request.BirthDate,
                Name = request.FirstName,
                Sex = request.Sex,
                LastChangePassword = CalendarHelper.GetCurrentDateTime()
            };

            await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsers>>().Add(user);



            var accessType = (await _unitOfWork.Repositorey<IGenericRepository<GFESUserAccessType>>().Find(a => a.Code == PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)).SingleOrDefault();
            accessType.Null(AnuResult.Can_Not_Find_AccessType);

            var najaUnit = (await _unitOfWork.Repositorey<INAJAUnitRepository>().GetByCode(PunishmentOrgConstants.NajaUnit.PunishmentOrg));
            najaUnit.Null(AnuResult.Can_Not_Find_AccessType);

            var userAccess = new GFESUserAccess()
            {
                Id = System.Guid.NewGuid().ToString("N"),
                FromDateTime = CalendarHelper.MinDateTime(),
                ToDateTime = CalendarHelper.MaxDateTime(),
                SignText = "کاربر سامانه ی 135 تازیرات",
                TheGFESUser = user,
                TheGFESUserAccessType = accessType,
                TheNAJAUnit = najaUnit
            };

            await _unitOfWork.Repositorey<IGenericRepository<GFESUserAccess>>().Add(userAccess);



            var currentDateTime = DateTime.Now;
            await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsersHistory>>().Add(new PBPuoUsersHistory()
            {
                Id = Guid.NewGuid().ToString("N"),
                DynomicPassword = passWordHash,
                SendCodeDateTime = currentDateTime.DateTimeToString(),
                ExpiredCodeDateTime = currentDateTime.AddSeconds(_SecodeWait).DateTimeToString(),
                CountCodePerDay = 1,
                ThePBPuoUsers = user
            });

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }
            #endregion

            return new FirstStepAuthResult() { CountCharacter = _CountCharacter, SecondsWait = _SecodeWait, Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args: request.PhoneNumber.Substring(request.PhoneNumber.Length - 4) + "*****09") };

        }


        [Route("api/v2/Login")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<AuthResult> V2Login([FromBody] SecondStepUserLoginRequest request)
        {
            #region ValidateInput
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
            request.Password.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();
            if (request.LoginType == LoginType.LoginWithSms)
            {
                request.Password.IsDigit(AnuResult.UserName_Or_PassWord_Is_Not_Valid, length: _CountCharacter);
            }
            #endregion

            string jwtToken = null;

            switch (request.LoginType)
            {
                case LoginType.LoginWithSms:

                    var pBPuoUsers = await ValidateSenedSmsCode(request.UserName, request.Password);

                    jwtToken = GenerateJwtToken(pBPuoUsers);
                    break;
                case LoginType.LoginWithUserAndPass:

                    var theGFESUser = await _unitOfWork.Repositorey<IGFESUserRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, request.Password);
                    theGFESUser.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

                    jwtToken = GenerateJwtToken(theGFESUser);
                    break;
            }


            return new AuthResult() { AccessToken = jwtToken, Result = AnuResult.Successful.GetResult() };

        }


        [Route("api/v1/ChangePhoneNumber")]
        [HttpPost]
        [PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)]
        public async Task<Result> ChangePhoneNumber([FromBody] ChangePhoneNumberRequest request)
        {
            #region ValidateInput
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
            request.NewPhoneNumber.NullOrWhiteSpace(AnuResult.PhoneNumber_Is_Not_Entered);
            request.Password.IsDigit(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();
            request.NewPhoneNumber.IsValidPhone();
            #endregion

            string jwtToken = null;

            var pBPuoUsers = await ValidateSenedSmsCode(request.UserName, request.Password);
            await ShahkarAuthentication.ShahkarAuthenticate(request.NewPhoneNumber, request.UserName);

            pBPuoUsers.MobileNumber4SMS = request.NewPhoneNumber;

            _unitOfWork.Repositorey<IPBPuoUsersRepository>().UpdateParent(pBPuoUsers);

            if (_unitOfWork.Complete() < 0)
            {
                return AnuResult.Error.GetResult();
            }

            return AnuResult.Successful.GetResult();

        }


        #region Change Phone Number WithOut Login

        [Route("api/v1/SendSmsForChangePhoneNumber")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<FirstStepAuthResult> SendSmsForChangePhoneNumber([FromBody] FirstStepUserLoginRequest request)
        {
            #region ValidateInput
            request.Null(SendSmsForChangePhoneNumberResult.SendSmsForChangePhoneNumber_request_Not_Valid);
            request.UserName.NullOrWhiteSpace(SendSmsForChangePhoneNumberResult.SendSmsForChangePhoneNumber_UserName_or_PhoneNumber_Not_Valid);
            request.MobileNumber.NullOrWhiteSpace(SendSmsForChangePhoneNumberResult.SendSmsForChangePhoneNumber_UserName_or_PhoneNumber_Not_Valid);
            request.MobileNumber.IsDigit(SendSmsForChangePhoneNumberResult.SendSmsForChangePhoneNumber_UserName_or_PhoneNumber_Not_Valid);
            request!.UserName!.IsValidNationalCode();
            #endregion

            #region ValidateUserHistory
            var pBPuoUsers = (await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsers>>()
                .Find(x => x.NationalityCode == request.UserName)).FirstOrDefault();
            pBPuoUsers.Null(SendSmsForChangePhoneNumberResult.SendSmsForChangePhoneNumber_Not_Find_User);
            if (pBPuoUsers.MobileNumber4SMS == request.MobileNumber)
            {
                return new FirstStepAuthResult() { Result = SendSmsForChangePhoneNumberResult.SendSmsForChangePhoneNumber_Mobile_Number_is_Repetitive.GetResult( args: pBPuoUsers.NationalityCode) };
            }
            await ShahkarAuthentication.ShahkarAuthenticate(request!.MobileNumber, request!.UserName);

            var lastRecordHistoryPerDay = await _unitOfWork.Repositorey<IPBPuoUsersHistoryRepository>().LastRecordHistoryPerDay(pBPuoUsers.Id, DateTime.Now.DateToString());

            if (lastRecordHistoryPerDay != null && !Anu.Utility.Utility.IsDevelopment())
            {
                var difDateSecond = (DateTime.Now - lastRecordHistoryPerDay.SendCodeDateTime.ToDateTime()).TotalSeconds;
                if (difDateSecond < _SecodeWait && lastRecordHistoryPerDay.SendCodeDateTime != lastRecordHistoryPerDay.ExpiredCodeDateTime)
                {
                    return new FirstStepAuthResult() { Result = AnuResult.Send_Login_Request_After_x_Second.GetResult(args: ((int)(_SecodeWait - difDateSecond)).ToString()) };
                }

                if (lastRecordHistoryPerDay.CountCodePerDay >= _LimitSendDayCodePerDay)
                {
                    return new FirstStepAuthResult() { Result = AnuResult.Sms_Limit_Send.GetResult() };
                }
            }
            #endregion ValidateUserHistory

            #region SendAndSubmitPassword
            string password = await request.MobileNumber.SendAuthenticateSms(_CountCharacter);
            string passWordHash = MD5Core.GetHashString(password);

            pBPuoUsers.DynomicPassword = passWordHash;
            _unitOfWork.Repositorey<IPBPuoUsersRepository>().UpdateParent(pBPuoUsers);

            var currentDateTime = DateTime.Now;
            var userHistory = new PBPuoUsersHistory()
            {
                Id = Guid.NewGuid().ToString("N"),
                DynomicPassword = passWordHash,
                SendCodeDateTime = currentDateTime.DateTimeToString(),
                ExpiredCodeDateTime = currentDateTime.AddSeconds(_SecodeWait).DateTimeToString(),
                CountCodePerDay = lastRecordHistoryPerDay == null ? 1 : lastRecordHistoryPerDay.CountCodePerDay + 1,
                ThePBPuoUsers = pBPuoUsers
            };
            await _unitOfWork.Repositorey<IGenericRepository<PBPuoUsersHistory>>().Add(userHistory);

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }
            #endregion

            return new FirstStepAuthResult()
            {
                CountCharacter = _CountCharacter,
                SecondsWait = _SecodeWait,
                Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args: request!.MobileNumber!.Substring(request.MobileNumber.Length - 4) + "*****09")
            };
        }

        [Route("api/v2/ChangePhoneNumber")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<Result> V2ChangePhoneNumber([FromBody] ChangePhoneNumberRequest request)
        {
            #region ValidateInput

            request.Null(V2ChangePhoneNumberResult.V2ChangePhoneNumber_request_Is_Not_Valid);
            request.UserName.NullOrWhiteSpace(V2ChangePhoneNumberResult.V2ChangePhoneNumber_UserName_Or_PassWord_Is_Not_Entered);
            request.Password!.IsDigit(V2ChangePhoneNumberResult.V2ChangePhoneNumber_UserName_Or_PassWord_Is_Not_Entered);
            request!.NewPhoneNumber.NullOrWhiteSpace(V2ChangePhoneNumberResult.V2ChangePhoneNumber_PhoneNumber_Is_Not_Entered);

            request.UserName!.IsValidNationalCode();
            request.NewPhoneNumber.IsValidPhone();

            #endregion ValidateInput

            var pBPuoUsers = await ValidateSenedSmsCode(request!.UserName, request!.Password);
            
            if (pBPuoUsers.MobileNumber4SMS == request.NewPhoneNumber)
            {
                return V2ChangePhoneNumberResult.V2ChangePhoneNumber_Mobile_Number_is_Repetitive.GetResult(args: pBPuoUsers.NationalityCode);
            }
            await ShahkarAuthentication.ShahkarAuthenticate(request!.NewPhoneNumber, request.UserName);
            pBPuoUsers.MobileNumber4SMS = request.NewPhoneNumber;

            _unitOfWork.Repositorey<IPBPuoUsersRepository>().UpdateParent(pBPuoUsers);

            if (_unitOfWork.Complete() < 0)
            {
                return AnuResult.Error.GetResult();
            }

            return AnuResult.Successful.GetResult();

        }

        #endregion Change Phone Number WithOut Login

        private async Task<PBPuoUsers> ValidateSenedSmsCode(string userName, string password)
        {
            var pBPuoUsers = await _unitOfWork.Repositorey<IPBPuoUsersRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(userName, password);
            pBPuoUsers.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            if (pBPuoUsers.TheGFESUserAccessList == null || pBPuoUsers.TheGFESUserAccessList.Count == 0)
            {
                throw new AnuExceptions(AnuResult.UserName_Or_PassWord_Is_Not_Valid);
            }

            var lastRecordHistoryPerDay = await _unitOfWork.Repositorey<IPBPuoUsersHistoryRepository>().LastRecordHistoryPerDay(pBPuoUsers.Id, DateTime.Now.DateToString());
            lastRecordHistoryPerDay.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            bool IsExpierd = false;
            //Check kardan expire shodan code
            if (lastRecordHistoryPerDay.ExpiredCodeDateTime.ToDateTime() < DateTime.Now.DateTimeToString().ToDateTime())
            {
                IsExpierd = true;
            }
            //check kardan in ke agar tarikh ersal va expiration barabar bashad iani az in code ghblan estefade shode ast
            if (lastRecordHistoryPerDay.ExpiredCodeDateTime.ToDateTime() == lastRecordHistoryPerDay.SendCodeDateTime.ToDateTime())
            {
                throw new AnuExceptions(AnuResult.Login_Again);
            }

            //tarikh expiration va iejade code ro dar sorate estefade az code baham barabar mikonim
            lastRecordHistoryPerDay.ExpiredCodeDateTime = lastRecordHistoryPerDay.SendCodeDateTime;

            if (!pBPuoUsers.SendDynomicPassword.NullOrEmpty())
            {
                pBPuoUsers.SendDynomicPassword = "";
                _unitOfWork.Repositorey<IPBPuoUsersRepository>().UpdateParent(pBPuoUsers);
            }

            if (_unitOfWork.Complete() < 0)
            {
                throw new AnuExceptions(AnuResult.Error);
            }

            if (IsExpierd)
            {
                throw new AnuExceptions(AnuResult.Sms_Time_Is_Expired);
            }

            return pBPuoUsers;
        }

        private string GenerateJwtToken(GFESUser theGFESUser)
        {
            var jwtTokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();

            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfig:Secret").Value);

            // Token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("IsDisable", "true"),
                    new Claim("permissions", this.GetPermissions(theGFESUser)),
                    new Claim("UserName", theGFESUser.UserID),
                    new Claim(JwtRegisteredClaimNames.Sub, theGFESUser.UserID),
                    new Claim(JwtRegisteredClaimNames.Email, value:theGFESUser.UserID),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToUniversalTime().ToString())
                }),

                Expires = DateTime.Now.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);
        }

        private string GetPermissions(GFESUser theGFESUser)
        {
            //return ";All;";
            if (theGFESUser.TheGFESUserAccessList == null)
            {
                return ";All;";
            }
            var theGFESUserAccessTypeCodes = string.Join(';', theGFESUser.TheGFESUserAccessList.Select(x => x.TheGFESUserAccessType.Code));
            return theGFESUserAccessTypeCodes;
        }
    }

    public abstract class AttributeAuthorizationHandler<TRequirement, TAttribute> : AuthorizationHandler<TRequirement> where TRequirement : IAuthorizationRequirement where TAttribute : Attribute
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TRequirement requirement)
        {
            var attributes = new List<TAttribute>();

            var action = (context.Resource as Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext)?.ActionDescriptor as Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor;
            if (action != null)
            {
                attributes.AddRange(GetAttributes(action.ControllerTypeInfo.UnderlyingSystemType));
                attributes.AddRange(GetAttributes(action.MethodInfo));
            }

            return HandleRequirementAsync(context, requirement, attributes);
        }

        protected abstract Task HandleRequirementAsync(AuthorizationHandlerContext context, TRequirement requirement, IEnumerable<TAttribute> attributes);

        private static IEnumerable<TAttribute> GetAttributes(System.Reflection.MemberInfo memberInfo)
        {
            return memberInfo.GetCustomAttributes(typeof(TAttribute), false).Cast<TAttribute>();
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class PermissionAttribute : AuthorizeAttribute
    {
        public string Name { get; }

        public PermissionAttribute(string name) : base("Permission")
        {
            Name = name;
        }
    }

    public class PermissionAuthorizationRequirement : IAuthorizationRequirement
    {
        //Add any custom requirement properties if you have them
    }

    public class PermissionAuthorizationHandler : AttributeAuthorizationHandler<PermissionAuthorizationRequirement, PermissionAttribute>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionAuthorizationRequirement requirement, IEnumerable<PermissionAttribute> attributes)
        {
            foreach (var permissionAttribute in attributes)
            {
                if (!await AuthorizeAsync(context.User, permissionAttribute.Name))
                {
                    return;
                }
            }

            context.Succeed(requirement);
        }

        private async Task<bool> AuthorizeAsync(ClaimsPrincipal user, string permission)
        {
            var permissions = user.Claims.Where(x => x.Type == "permissions").Select(x => x.Value).FirstOrDefault();
            if (permissions == null)
            {
                return false;
            }

            var splitedPermissions = permissions.Split(";");
            if (splitedPermissions.Any(x => x.ToString().Contains(permission, StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }

            return false;
        }
    }
}