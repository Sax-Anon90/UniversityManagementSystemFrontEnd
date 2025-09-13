
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace UniversityManagementSystem.BlazorWASM.Client.Providers
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly JwtSecurityTokenHandler jwtSecurityTokenHandler;
        private readonly ILocalStorageService _localStorageService;

        public CustomAuthenticationStateProvider(ILocalStorageService _localStorageService)
        {
            this._localStorageService = _localStorageService;
            jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //Get Access Token First
            string savedToken = string.Empty;


            savedToken = await _localStorageService.GetItemAsync<string>("AccessToken");

            if (string.IsNullOrEmpty(savedToken))
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            else
            {

                //Get claims from token
                var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(savedToken);
                if (tokenContent.ValidTo < DateTime.Now)
                {
                    return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

                }

                var claims = tokenContent.Claims;

                var tokenUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
                return new AuthenticationState(tokenUser);



            }
        }

        public async Task LoggedInAuthenticationState()
        {
            var savedToken = await _localStorageService.GetItemAsync<string>("AccessToken");
            var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(savedToken);
            var claims = tokenContent.Claims;
            var tokenUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
            var authState = Task.FromResult(new AuthenticationState(tokenUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public async Task LoggedOutAuthenticationState()
        {
            await _localStorageService.ClearAsync();
            var nobody = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(nobody));
            NotifyAuthenticationStateChanged(authState);
        }


    }
}
