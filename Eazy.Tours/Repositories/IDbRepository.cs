namespace Eazy.Tours.Repositories
{
    public interface IDbRepository
    {
        User GetUserById(int id);
    }
}