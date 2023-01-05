using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Mocks
{
    public class MockUserRole : IUserRole
    {
        public IEnumerable<UserRole> GetUserRoles
        {
            get 
            {
                return new List<UserRole> { 
                    new UserRole {Id = 1, RoleName = "System administrator" },
                    new UserRole {Id = 2, RoleName = "Competition administrator" },
                    new UserRole {Id = 3, RoleName = "Participant" }
                };
            }
        }
    }
}
