using Domain.Entities.Abstracts;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity;

public class Token: IdentityUserToken<int>,IBaseEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime ExpireDate { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime LastUpdatedTime { get; set; }
    public bool IsDeleted { get; set; }
}