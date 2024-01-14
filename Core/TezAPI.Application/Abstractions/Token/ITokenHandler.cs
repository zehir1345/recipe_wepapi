using TezAPI.Domain.Entities.Identity;

namespace TezAPI.Application.Abstractions.Token;
public interface ITokenHandler
{
    DTOs.Token CreateAccessToken(int second);
}
