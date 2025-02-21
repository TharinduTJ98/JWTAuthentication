using JWTAuthentication.Entities;
using JWTAuthentication.Models;

namespace JWTAuthentication.Services
{
    public interface IAuthService
    {
        public Task<string?> LogingAsync(UserDto request);
        public Task<User?> RegusterAsync(UserDto request);
    }
}
