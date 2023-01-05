using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Mocks
{
    public class MockUserStatus : IUserStatus
    {
        public IEnumerable<UserStatus> GetUserStatuses
        {
            get
            {
                return new List<UserStatus>
                {
                    new UserStatus { Id = 1, UserStatusName = "active"},
                    new UserStatus { Id = 2, UserStatusName = "not active"}
                };
            }
        }
    }
}
