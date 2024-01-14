using Microsoft.AspNetCore.Identity;

namespace TezAPI.Domain.Entities.Identity;
public class AppUser : IdentityUser 
{
    public string NameSurname { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    //bunlar silinecek
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }
}
