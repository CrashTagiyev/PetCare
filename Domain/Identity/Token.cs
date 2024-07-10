using Microsoft.AspNetCore.Identity;

namespace Domain.Identity;

public class Token: IdentityUserToken<int>
{
    public DateTime CreatedAt { get; set; }
    public DateTime ExpireDate { get; set; }
}