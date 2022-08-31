using Anu.BaseInfo.DataAccess.FrontEndSecurity;
using Anu.BaseInfo.DataModel.FrontEndSecurity;
using Anu.BaseInfo.Domain.FrontEndSecurity;
using Anu.Commons.ServiceModel.ServiceAuthentication;
using Anu.Commons.ServiceModel.ServiceAuthentication.Enumerations;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Authentication.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Utility;
using Utility.CalendarHelper;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Authentication
{
    public class AuthenticationController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationController(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }

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

            string password = await theGFESUser.MobileNumber4SMS.SendAuthenticateSms(6);
            string passWordHash = MD5Core.GetHashString(password);

            theGFESUser.Password = passWordHash;

            if (_unitOfWork.Complete() < 0)
            {
                return new FirstStepAuthResult() { Result = AnuResult.Error.GetResult() };
            }

            return new FirstStepAuthResult() { CountCharacter = 6, SecondsWait = 120, Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args:  theGFESUser.MobileNumber4SMS.Substring(theGFESUser.MobileNumber4SMS.Length - 4) + "*****09") };

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
            await request.SabteahvalAuthenticate();


            string password = await request.PhoneNumber.SendAuthenticateSms(6);
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
                LastChangePassword = CalendarHelper.GetCurrentDateTime(),
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

            return new FirstStepAuthResult() { CountCharacter = 6, SecondsWait = 120, Result = AnuResult.LoginSuccessful_Sms_Send_To.GetResult(args:  request.PhoneNumber.Substring(request.PhoneNumber.Length - 4) + "*****09") };

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
                    //check the database for how seconds pass and is the code valid
                    break;
            }

            var jwtToken = GenerateJwtToken(theGFESUser);

            return new AuthResult() { AccessToken = jwtToken, Result = AnuResult.Successful.GetResult() };

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