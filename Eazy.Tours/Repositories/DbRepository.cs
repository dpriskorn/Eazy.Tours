namespace Eazy.Tours.Repositories
{
    public class DbRepository : IDbRepository
    {
        private readonly AppDbContext _db;

        public DbRepository(AppDbContext db)
        {
            _db = db;
        }

        public User GetUserById (int id)
        {
            var user = _db.Users.Find(id);
            return user;
        }

    }
}
