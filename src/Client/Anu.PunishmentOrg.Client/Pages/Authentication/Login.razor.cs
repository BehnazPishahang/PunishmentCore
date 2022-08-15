﻿using Anu.Commons.ServiceModel.ServiceLogin;
using Anu.PunishmentOrg.Client.Infrastructure.Login;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Pages.Authentication
{
    public partial class Login
    {
       
     //   private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });
        private UserLoginRequest _tokenModel = new();

        private bool Validated = true;

        //protected override async Task OnInitializedAsync()
        //{
        //    //var state = await _stateProvider.GetAuthenticationStateAsync();
        //    //if (state != new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())))
        //    //{
        //    //    _navigationManager.NavigateTo("/");
        //    //}
        //}

        private async Task SubmitAsync()
        {
            /// var result = await _authenticationManager.Login(_tokenModel);
            //if (!result.Succeeded)
            //{
            //    foreach (var message in result.Messages)
            //    {
            //        _snackBar.Add(message, Severity.Error);
            //    }
            //}
           // _navigationManager.NavigateTo("/Dashboard");
        }

        private  void onlogin()
        {
            /// var result = await _authenticationManager.Login(_tokenModel);
            //if (!result.Succeeded)
            //{
            //    foreach (var message in result.Messages)
            //    {
            //        _snackBar.Add(message, Severity.Error);
            //    }
            //}
           // _navigationManager.NavigateTo("/Dashboard");
        }
        private bool _passwordVisibility;
        private InputType _passwordInput = InputType.Password;
        private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;

        void TogglePasswordVisibility()
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

        private void FillAdministratorCredentials()
        {
            _tokenModel.UserName = "mukesh@blazorhero.com";
            _tokenModel.Password = "123Pa$$word!";
        }

        private void FillBasicUserCredentials()
        {
            _tokenModel.Password = "john@blazorhero.com";
            _tokenModel.Password = "123Pa$$word!";
        }
    }
}