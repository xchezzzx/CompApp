using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface IUserRole
    {
        IEnumerable<UserRole> GetUserRoles { get; }
    }
}
