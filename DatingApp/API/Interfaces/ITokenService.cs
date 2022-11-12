using API.Entities;

namespace API.Interfaces;

public interface ITokenService
{
    string CreteToken(AppUser user);
}