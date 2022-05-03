using Microsoft.AspNetCore.Identity;

namespace Eazy.Tours.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
