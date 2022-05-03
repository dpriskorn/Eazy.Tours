using Eazy.Tours.Areas.Identity.Data;

namespace Eazy.Tours.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LoginDbContext _context;

        public UserRepository(LoginDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Gets user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User</returns>
        public ApplicationUser GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public ICollection<ApplicationUser> GetUsers()
        {
            return _context.Users.ToList();
        }
        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Updated user</returns>
        public ApplicationUser UpdateUser(ApplicationUser user)
        {
            _context.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
