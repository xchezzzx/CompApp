using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> GetUsers { get; }
        IEnumerable<User> GetActiveUsers { get; }
        User GetUser(int id);

    }
}
