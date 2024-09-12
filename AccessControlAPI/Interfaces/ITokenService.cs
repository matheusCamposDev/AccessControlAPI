using AccessControlAPI.Models;

namespace AccessControlAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
