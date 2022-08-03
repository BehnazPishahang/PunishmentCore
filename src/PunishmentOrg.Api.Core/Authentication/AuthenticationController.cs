using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Anu.PunishmentOrg.Api.Authentication
{
    public class User
    {
    }
    public class UserLoginRequestDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? PhoneNumber { get; set; }
    }

    public class AuthResult
    {
        public string? Token { get; set; }
        public bool Result { get; set; }
        public List<string>? Errors { get; set; }
    }

    public class AuthenticationController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("Login")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestDto loginRequest)
        {
            // Check if the user exist
            //var existing_user;// await _userManager.FindByEmailAsync(loginRequest.Email);

            if (loginRequest == null)
                return BadRequest(new AuthResult() { Errors = new List<string>() { "Invalid payload" }, Result = false });

            //var isCorrect = await _userManager.CheckPasswordAsync(existing_user, loginRequest.Password);

            //if (!isCorrect)
            //    return BadRequest(new AuthResult() { Errors = new List<string>() { "Invalid credentials" }, Result = false });

            var jwtToken = GenerateJwtToken(loginRequest);

            return Ok(new AuthResult() { Token = jwtToken, Result = true });

            //return BadRequest(new AuthResult() { Errors = new List<string>() { "Invalid payload" }, Result = false });
        }

        private string GenerateJwtToken(UserLoginRequestDto user)
        {
            var jwtTokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();

            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfig:Secret").Value);

            // Token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id),
                    new Claim("IsDisable", "true"),
                    new Claim("permissions", ";SendPBillStore;" ),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Email, value:user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToUniversalTime().ToString())
                }),

                Expires = DateTime.Now.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);
        }

    }

    //public interface IJwtTokenGenerator
    //{
    //    string GenerateToken(Guid Id, string firstName, string lastName, string email);
    //}

    //public class JwtTokenGenerator : IJwtTokenGenerator
    //{
    //    public string GenerateToken(Guid Id, string firstName, string lastName, string email)
    //    {
    //        return "";
    //    }
    //}
    ///////////////////////////////////////////
    ///



    public class IsAccountEnabledRequirement : Microsoft.AspNetCore.Authorization.IAuthorizationRequirement
    {
        public IsAccountEnabledRequirement()
        {

        }
    }

    public class IsAllowedToManageProductRequirement : Microsoft.AspNetCore.Authorization.IAuthorizationRequirement
    {
        public IsAllowedToManageProductRequirement()
        {

        }
    }

    public class IsEmployeeHandler : Microsoft.AspNetCore.Authorization.AuthorizationHandler<IsAllowedToManageProductRequirement>
    {
        protected override Task HandleRequirementAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext context, IsAllowedToManageProductRequirement requirement)
        {
            if (context.User.HasClaim(f => f.Type == "Employee"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

    public class IsVIPCustomerHandler : Microsoft.AspNetCore.Authorization.AuthorizationHandler<IsAllowedToManageProductRequirement>
    {
        protected override Task HandleRequirementAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext context, IsAllowedToManageProductRequirement requirement)
        {
            if (context.User.HasClaim(f => f.Type == "VIP"))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }

    public class IsAccountNotDisabledHandler : Microsoft.AspNetCore.Authorization.AuthorizationHandler<IsAccountEnabledRequirement>
    {
        public override Task HandleAsync(AuthorizationHandlerContext context)
        {
            
            return base.HandleAsync(context);
        }
        protected override Task HandleRequirementAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext context, IsAccountEnabledRequirement requirement)
        {
            if (context.User.HasClaim(f => f.Type == "Disabled"))
            {
                context.Fail();
            }
            else
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

    public class MinimumAgeRequirement : Microsoft.AspNetCore.Authorization.IAuthorizationRequirement
    {
        public MinimumAgeRequirement(string minimumAge) =>
            MinimumAge = minimumAge;

        public string MinimumAge { get; }
    }

    public class MinimumAgeHandler : Microsoft.AspNetCore.Authorization.AuthorizationHandler<MinimumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            var dateOfBirthClaim = context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth && c.Issuer == "http://contoso.com");

            if (dateOfBirthClaim is null)
            {
                return Task.CompletedTask;
            }

            //var dateOfBirth = Convert.ToDateTime(dateOfBirthClaim.Value);
            //int calculatedAge = DateTime.Today.Year - dateOfBirth.Year;
            //if (dateOfBirth > DateTime.Today.AddYears(-calculatedAge))
            //{
            //    calculatedAge--;
            //}

            if ("All" == requirement.MinimumAge)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }

    public class AuthorizeAdminOrMember : AuthorizeAttribute
    {
        public AuthorizeAdminOrMember()
        {
            Roles = "members, admin";
        }
    }








    public static class PrincipalPermission
    {

        public static List<Func<Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext, bool>> Criteria = new List<Func<Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext, bool>>
        {
            CanCreateUser
        };

        public static bool CanCreateUser(this Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext authorizationHandlerContext)
        {
            //return ctx.User.IsInRole(RoleEnum.Admin.ToString());

            if (authorizationHandlerContext.User.HasClaim(f => f.Type == "Disabled"))
            {
                //authorizationHandlerContext.Fail();
                return false;
            }
            else
            {
                //authorizationHandlerContext.Succeed(requirement);
                return true;
            }
            //return Task.CompletedTask;
        }
    }


    public class CustomUserRequireClaim : IAuthorizationRequirement
    {
        public string ClaimType { get; }
        public CustomUserRequireClaim(string claimType)
        {
            ClaimType = claimType;
        }
    }

    public class PoliciesAuthorizationHandler : AuthorizationHandler<CustomUserRequireClaim>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,CustomUserRequireClaim requirement)
        {
            if (context.User == null || !context.User.Identity.IsAuthenticated)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            var hasClaim = context.User.Claims.Any(x => x.Type == requirement.ClaimType);

            if (hasClaim)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            context.Fail();
            return Task.CompletedTask;
        }
    }
    //public class RolesAuthorizationHandler : AuthorizationHandler<RolesAuthorizationRequirement>, IAuthorizationHandler
    //{
    //    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RolesAuthorizationRequirement requirement)
    //    {
    //        if (context.User == null || !context.User.Identity.IsAuthenticated)
    //        {
    //            context.Fail();
    //            return Task.CompletedTask;
    //        }

    //        var validRole = false;
    //        if (requirement.AllowedRoles == null ||
    //            requirement.AllowedRoles.Any() == false)
    //        {
    //            validRole = true;
    //        }
    //        else
    //        {
    //            var claims = context.User.Claims;
    //            var userName = claims.FirstOrDefault(c => c.Type == "UserName").Value;
    //            var roles = requirement.AllowedRoles;

    //            validRole = new Users().GetUsers().Where(p => roles.Contains(p.Role) && p.UserName == userName).Any();
    //        }

    //        if (validRole)
    //        {
    //            context.Succeed(requirement);
    //        }
    //        else
    //        {
    //            context.Fail();
    //        }
    //        return Task.CompletedTask;
    //    }
    //}





    public class AccountRequirement : IAuthorizationRequirement { }

    public class AccountHandler : AuthorizationHandler<AccountRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,AccountRequirement requirement)
        {
            var httpMethod = _httpContextAccessor.HttpContext.Request.Method;
            var endpoint = _httpContextAccessor.HttpContext.GetEndpoint(); 
            if (httpMethod == "POST")
            {
                context.Succeed(requirement);
            }


            return Task.CompletedTask;
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
            if(splitedPermissions.Any(x => x.ToString().Contains(permission, StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }

            return false;
        }

        //private Task<bool> AuthorizeAsync(AuthorizationHandlerContext context, string permission)
        //{
        //    IEnumerable<string> permissions = context.User.Claims
        //                             .Where(x => x.Type == "permissions")
        //                             .Select(y => y.Value);

        //    if (permissions.Contains(permission))
        //    {
        //        return new Task<bool>(() => true);
        //    }

        //    return new Task<bool>(() => false);
        //}
    }






}