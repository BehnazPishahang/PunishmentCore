﻿using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class AuthResult : IResponseMessage
    {
        public string? AccessToken { get; set; }

        public string? RefreshToken { get; set; }

        public Result Result { get; set; }
    }
}
