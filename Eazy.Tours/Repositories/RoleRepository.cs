using Microsoft.AspNetCore.Identity;

namespace Eazy.Tours.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly LoginDbContext _context;
        public RoleRepository(LoginDbContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
