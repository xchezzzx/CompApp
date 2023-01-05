using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface IUserStatus
    {
        IEnumerable<UserStatus> GetUserStatuses { get; }
    }
}
