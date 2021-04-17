using System.Security.Claims;
using System.Threading.Tasks;

namespace PrisonBack.Auth.FacebookAuth.Jwt
{
    public interface IJwtFactory
    {
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id);
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
    }
}