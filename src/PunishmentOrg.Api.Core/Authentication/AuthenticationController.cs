using Anu.BaseInfo.DataAccess.FrontEndSecurity;
using Anu.BaseInfo.DataModel.FrontEndSecurity;
using Anu.BaseInfo.Domain.FrontEndSecurity;
using Anu.Commons.ServiceModel.ServiceAuthentication;
using Anu.Commons.ServiceModel.ServiceAuthentication.Enumerations;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
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
        private readonly int _SecodeWait = 60;
        private readonly int _CountCharacter = 6;
        private readonly int _LimitSendDayCodePerDay = 4;
        private readonly string _NotVerify = "|NotVerify";


        public AuthenticationController(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }

        [Route("api/v1/SendSmsAuth")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<FirstStepAuthResult> SendSmsAuth([FromBody] FirstStepUserLoginRequest request)
        {
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();

            var punishmentOrg135Users = (await _unitOfWork.Repositorey<IGenericRepository<PunishmentOrg135Users>>()
                .Find(x => x.NationalityCode == request.UserName)).FirstOrDefault();
            punishmentOrg135Users.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            var lastRecordHistoryPerDay = await _unitOfWork.Repositorey<IUsers135LoginHistoryRepository>().LastRecordHistoryPerDay(punishmentOrg135Users.Id, DateTime.Now.DateToString());

            if (lastRecordHistoryPerDay != null)
            {
                var difDateSecond = (DateTime.Now - lastRecordHistoryPerDay.SendCodeDateTime.ToDateTime()).TotalSeconds;
                if (difDateSecond < _SecodeWait && lastRecordHistoryPerDay.SendCodeDateTime!=lastRecordHistoryPerDay.ExpiredCodeDateTime)
                {
                    return new FirstStepAuthResult() { Result = AnuResult.Send_Login_Request_After_x_Second.GetResult(args: (_SecodeWait - difDateSecond).ToString()) };
                }

                if (lastRecordHistoryPerDay.SendCodePerDay >= _LimitSendDayCodePerDay)
                {
                    return new FirstStepAuthResult() { Result = AnuResult.Sms_Limit_Send.GetResult() };
                }
            }

            string password = await punishmentOrg135Users.MobileNumber4SMS.SendAuthenticateSms(_CountCharacter);
            string passWordHash = MD5Core.GetHashString(password);

            if ((await _unitOfWork.Repositorey<IPunishmentOrg135UsersRepository>().UpdateDynamicPassword(punishmentOrg135Users.Id,passWordHash)) < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }            

            var currentDateTime = DateTime.Now;
            var user = new Users135LoginHistory()
            {
                Id = Guid.NewGuid().ToString("N"),
                SmsCode = passWordHash,
                SendCodeDateTime = currentDateTime.DateTimeToString(),
                ExpiredCodeDateTime = currentDateTime.AddSeconds(_SecodeWait).DateTimeToString(),
                SendCodePerDay = lastRecordHistoryPerDay == null ? 1 : lastRecordHistoryPerDay.SendCodePerDay + 1,
                ThePunishmentOrg135Users = punishmentOrg135Users
            };
            await _unitOfWork.Repositorey<IGenericRepository<Users135LoginHistory>>().Add(user);

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }

            return new FirstStepAuthResult()
            {
                CountCharacter = _CountCharacter,
                SecondsWait = _SecodeWait,
                Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args: punishmentOrg135Users.MobileNumber4SMS.Substring(punishmentOrg135Users.MobileNumber4SMS.Length - 4) + "*****09")
            };

        }

        [Route("api/v1/Register")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<FirstStepAuthResult> Register([FromBody] UserRegisterRequest request)
        {
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


            var punishmentOrg135Users = (await _unitOfWork.Repositorey<IGenericRepository<PunishmentOrg135Users>>().Find(a => a.UserID == request.UserName)).FirstOrDefault();

            if (punishmentOrg135Users != null)
            {
                //var lastRecordHistory = await _unitOfWork.Repositorey<IUsers135LoginHistoryRepository>().LastRecordHistory(punishmentOrg135Users.Id);
                if (!punishmentOrg135Users.SendDynomicPassword.Substring(punishmentOrg135Users.SendDynomicPassword.Length - _NotVerify.Length).Equals(_NotVerify))
                {
                    return new FirstStepAuthResult() { Result = AnuResult.User_Is_Exist.GetResult() };
                }
                else
                {
                    if ((await _unitOfWork.Repositorey<IPunishmentOrg135UsersRepository>().DeleteUser(punishmentOrg135Users.Id)) < 0)
                    {
                        return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
                    }
                }
            }





            //await ShahkarAuthentication.ShahkarAuthenticate(request.PhoneNumber, request.UserName);
            //await SabteahvalAuthentication.SabteahvalAuthenticate(request);


            string password = await request.PhoneNumber.SendAuthenticateSms(_CountCharacter);
            string passWordHash = MD5Core.GetHashString(password);

            var user = new PunishmentOrg135Users()
            {
                Id = System.Guid.NewGuid().ToString("N"),
                UserID = request.UserName,
                Password = passWordHash,
                DynomicPassword = passWordHash,
                SendDynomicPassword = passWordHash + _NotVerify,
                MobileNumber4SMS = request.PhoneNumber,
                NationalityCode = request.UserName,
                StartDate = CalendarHelper.GetCurrentDateTime(),
                EndDate = CalendarHelper.MaxDateTime(),
                Family = request.LastName,
                FatherName = request.BirthDate,
                Name = request.FirstName,
                Sex = request.Sex,
                LastChangePassword = CalendarHelper.GetCurrentDateTime()
            };

            await _unitOfWork.Repositorey<IGenericRepository<PunishmentOrg135Users>>().Add(user);

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }

            var currentDateTime = DateTime.Now;
            await _unitOfWork.Repositorey<IGenericRepository<Users135LoginHistory>>().Add(new Users135LoginHistory()
            {
                Id = Guid.NewGuid().ToString("N"),
                SmsCode = passWordHash,
                SendCodeDateTime = currentDateTime.DateTimeToString(),
                ExpiredCodeDateTime = currentDateTime.AddSeconds(_SecodeWait).DateTimeToString(),
                SendCodePerDay = 1,
                ThePunishmentOrg135Users = user
            });

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }

            return new FirstStepAuthResult() { CountCharacter = _CountCharacter, SecondsWait = _SecodeWait, Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args: request.PhoneNumber.Substring(request.PhoneNumber.Length - 4) + "*****09") };

        }


        [Route("api/v1/Login")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<AuthResult> Login([FromBody] SecondStepUserLoginRequest request)
        {
           

            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);
            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
            request.Password.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();
            if (request.LoginType == LoginType.LoginWithSms)
            {
                request.Password.IsDigit(AnuResult.UserName_Or_PassWord_Is_Not_Valid, length: _CountCharacter);
            }

            string jwtToken = null;

            var loginProvider = Factory.GetInstance(LoginType.LoginWithSms);
            var loginResult = await loginProvider.VerifyAsync(request);
            if (loginResult.Result.Code == 1000)
            {

            }


            //switch (request.LoginType)
            //{
            //    case LoginType.LoginWithSms:
            //        var punishmentOrg135Users = await _unitOfWork.Repositorey<IPunishmentOrg135UsersRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, request.Password);
            //        punishmentOrg135Users.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            //        var lastRecordHistoryPerDay = await _unitOfWork.Repositorey<IUsers135LoginHistoryRepository>().LastRecordHistoryPerDay(punishmentOrg135Users.Id, DateTime.Now.DateToString());
            //        lastRecordHistoryPerDay.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            //        bool IsExpierd = false;
            //        if (lastRecordHistoryPerDay.ExpiredCodeDateTime.ToDateTime() < DateTime.Now.DateTimeToString().ToDateTime())
            //        {
            //            IsExpierd = true;
            //        }
            //        if (lastRecordHistoryPerDay.ExpiredCodeDateTime.ToDateTime() == lastRecordHistoryPerDay.SendCodeDateTime.ToDateTime())
            //        {
            //            return new AuthResult() { Result = AnuResult.Login_Again.GetResult() };
            //        }

            //        lastRecordHistoryPerDay.ExpiredCodeDateTime = lastRecordHistoryPerDay.SendCodeDateTime;

            //        if (_unitOfWork.Complete() < 0)
            //        {
            //            return new AuthResult() { Result = AnuResult.Error.GetResult() };
            //        }

            //        if (IsExpierd)
            //        {
            //            return new AuthResult() { AccessToken = null, Result = AnuResult.Sms_Time_Is_Expired.GetResult() };
            //        }

            //        jwtToken = GenerateJwtToken(punishmentOrg135Users);
            //        break;
            //    case LoginType.LoginWithUserAndPass:

            //        var theGFESUser = await _unitOfWork.Repositorey<IGFESUserRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, request.Password);
            //        theGFESUser.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            //        jwtToken = GenerateJwtToken(theGFESUser);
            //        break;
            //}


            return new AuthResult() { AccessToken = jwtToken, Result = AnuResult.Successful.GetResult() };

        }


        [Route("api/v1/ChangePhoneNumber")]
        [HttpPost]
        [HttpPost]
        public async Task<Result> ChangePhoneNumber([FromBody] ChangePhoneNumberRequest request)
        {

            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
            request.NewPhoneNumber.NullOrWhiteSpace(AnuResult.PhoneNumber_Is_Not_Entered);
            request.Password.IsDigit(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            request.UserName.IsValidNationalCode();
            request.NewPhoneNumber.IsValidPhone();

            string jwtToken = null;

            var punishmentOrg135Users = await _unitOfWork.Repositorey<IPunishmentOrg135UsersRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, request.Password);
            punishmentOrg135Users.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            var lastRecordHistoryPerDay = await _unitOfWork.Repositorey<IUsers135LoginHistoryRepository>().LastRecordHistoryPerDay(punishmentOrg135Users.Id, DateTime.Now.DateToString());
            lastRecordHistoryPerDay.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            bool IsExpierd = false;
            if (lastRecordHistoryPerDay.ExpiredCodeDateTime.ToDateTime() < DateTime.Now.DateTimeToString().ToDateTime())
            {
                IsExpierd = true;
            }
            if (lastRecordHistoryPerDay.ExpiredCodeDateTime.ToDateTime() == lastRecordHistoryPerDay.SendCodeDateTime.ToDateTime())
            {
                return AnuResult.Login_Again.GetResult();
            }

            //await ShahkarAuthentication.ShahkarAuthenticate(request.NewPhoneNumber, request.UserName);

            
            if ((await _unitOfWork.Repositorey<IPunishmentOrg135UsersRepository>().UpdatePhoneNumber(punishmentOrg135Users.Id,request.NewPhoneNumber)) < 0)
            {
                return AnuResult.Error.GetResult();
            }

            lastRecordHistoryPerDay.ExpiredCodeDateTime = lastRecordHistoryPerDay.SendCodeDateTime;



            if (_unitOfWork.Complete() < 0)
            {
                return AnuResult.Error.GetResult();
            }

            if (IsExpierd)
            {
                return AnuResult.Sms_Time_Is_Expired.GetResult();
            }

            return AnuResult.Successful.GetResult();

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

    public static class Factory
    {
        private static Dictionary<LoginType, Type> _loginTypesDictionary = new Dictionary<LoginType, Type>()
        {
            { LoginType.LoginWithSms        , typeof(LogInProviderWithSMS)},
            { LoginType.LoginWithUserAndPass, typeof(LogInProviderWithUserAndPass)}
        };

        public static ILogInProvider GetInstance(LoginType logInType)
        {
            return (ILogInProvider)Activator.CreateInstance(_loginTypesDictionary[logInType]);
        }
    }

    public interface ILogInProvider
    {
        Task<AuthResult> VerifyAsync(SecondStepUserLoginRequest secondStepUserLoginRequest);
    }

    public abstract class LogInProvider : ILogInProvider
    {
        public virtual async Task<AuthResult> VerifyAsync(SecondStepUserLoginRequest secondStepUserLoginRequest)
        {
            return await Task.FromResult(new AuthResult() 
            { 
                AccessToken = "", 
                RefreshToken = "LogInProvider", 
                Result = new Commons.ServiceModel.ServiceResponse.Result() 
                { 
                    Code = 1000,
                    Message = "LogInProvider",
                    Description = "LogInProvider",
                } 
            });
        }
    }

    public class LogInProviderWithUserAndPass : LogInProvider
    {
        public override async Task<AuthResult> VerifyAsync(SecondStepUserLoginRequest secondStepUserLoginRequest)
        {
            return await Task.FromResult(new AuthResult()
            {
                AccessToken = "",
                RefreshToken = "LogInProviderWithUserAndPass",
                Result = new Commons.ServiceModel.ServiceResponse.Result()
                {
                    Code = 1000,
                    Message = "LogInProviderWithUserAndPass",
                    Description = "LogInProviderWithUserAndPass",
                }
            });
        }
    }

    public class LogInProviderWithSMS : LogInProvider
    {
        public override async Task<AuthResult> VerifyAsync(SecondStepUserLoginRequest secondStepUserLoginRequest)
        {
            return await Task.FromResult(new AuthResult()
            {
                AccessToken = "",
                RefreshToken = "LogInProviderWithSMS",
                Result = new Commons.ServiceModel.ServiceResponse.Result()
                {
                    Code = 1000,
                    Message = "LogInProviderWithSMS",
                    Description = "LogInProviderWithSMS",
                }
            });
        }
    }
}