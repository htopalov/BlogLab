using BlogLab.Models.Account;

namespace BlogLab.Services
{
    public interface ITokenService
    {
        string CreateToken(ApplicationUserIdentity user);
    }
}
