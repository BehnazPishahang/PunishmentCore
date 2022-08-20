using Anu.Commons.ServiceModel.ServiceLogin;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.Client.Infrastructure.Login;
using Anu.PunishmentOrg.Client.Infrastructure.Notice;
using Blazored.FluentValidation;
using MudBlazor;

namespace Anu.PunishmentOrg.Client.Pages.Authentication
{
    public partial class Register
    {
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated = true; // => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });
        private UserRegisterRequest _registerUserModel = new();
        private string errorMessage = string.Empty;
        private async Task SubmitAsync()
        {
            AuthResult result = AuthorizationService.RegisterUser(_registerUserModel);

            if (result.Result.Code == (int)AnuResult.Successful)
            {
                SharedInfo.NationalCode = _registerUserModel.UserName;
                _navigationManager.NavigateTo("/true");
                errorMessage = "";
            }
            else
            {
                errorMessage = result.Result.Message;
            }
        }

        private bool _passwordVisibility;
        private InputType _passwordInput = InputType.Password;
        private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;

        private void TogglePasswordVisibility()
        {
            if (_passwordVisibility)
            {
                _passwordVisibility = false;
                _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
                _passwordInput = InputType.Password;
            }
            else
            {
                _passwordVisibility = true;
                _passwordInputIcon = Icons.Material.Filled.Visibility;
                _passwordInput = InputType.Text;
            }
        }
    }
}