using Anu.BaseInfo.DataAccess.FrontEndSecurity;
using Anu.BaseInfo.DataModel.ExchangeData;
using Anu.BaseInfo.DataModel.FrontEndSecurity;
using Anu.BaseInfo.DataModel.SystemObject;
using Anu.BaseInfo.Domain.FrontEndSecurity;
using Anu.Commons.ServiceModel.ServiceLogin;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.Domain.DiscoveryMinutes;
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

        public AuthenticationController(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }

        [Route("api/v1/Login")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<AuthResult> Login([FromBody] UserLoginRequest request)
        {

            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

                request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
                request.Password.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

                //var NAJAUnitsWithNullParent = _unitOfWork.Repositorey<GenericRepository<NAJAUnit>>().Find(x => x.TheParentUnit == null).Count();
                //var ObjectStateAll = _unitOfWork.Repositorey<GenericRepository<ObjectState>>().GetAll();
                var theGFESUser = await _unitOfWork.Repositorey<GFESUserRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, request.Password);
                theGFESUser.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            var jwtToken = GenerateJwtToken(theGFESUser);

            return new AuthResult() { AccessToken = jwtToken, RefreshToken = "", Result = AnuResult.Successful.GetResult() };

        }

        [Route("api/v1/Register")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<AuthResult> Register([FromBody] UserRegisterRequest request)
        {
            request.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

                request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
                request.Password.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
                request.PhoneNumber.NullOrWhiteSpace(AnuResult.PhoneNumber_Is_Not_Entered);

            request.UserName.IsValidNationalCode();
            request.PhoneNumber.IsValidPhone();

            if (await _unitOfWork.Repositorey<GenericRepository<GFESUser>>().Exist(a => a.UserID == request.UserName))
            {
                return new AuthResult() { AccessToken = "", RefreshToken = "", Result = AnuResult.User_Is_Exist.GetResult() };
            }

                string passWordHash = MD5Core.GetHashString(request.Password);

            var user = new GFESUser()
            {
                Id = System.Guid.NewGuid().ToString("N"),
                UserID = request.UserName,
                Password = passWordHash,
                MobileNumber4SMS = request.PhoneNumber,
                NationalityCode = request.UserName,
                StartDate = CalendarHelper.GetCurrentDateTime(),
                EndDate = CalendarHelper.MaxDateTime(),
                Family = "a",
                FatherName = "b",
                LastChangePassword = CalendarHelper.GetCurrentDateTime(),
                Name = "c",
                Sex = Anu.BaseInfo.Enumerations.SexType.None
            };

            await _unitOfWork.Repositorey<GenericRepository<GFESUser>>().Add(user);

            if (_unitOfWork.Complete() < 0)
            {
                return new AuthResult() { AccessToken = "", RefreshToken = "", Result = AnuResult.Error.GetResult() };
            }


                var theGFESUser = await _unitOfWork.Repositorey<GFESUserRepository>().GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(request.UserName, request.Password);
                theGFESUser.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            var jwtToken = GenerateJwtToken(theGFESUser);

            return new AuthResult() { AccessToken = jwtToken, RefreshToken = "", Result = AnuResult.Successful.GetResult() };


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