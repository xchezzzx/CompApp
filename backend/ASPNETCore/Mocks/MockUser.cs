using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Mocks
{
    public class MockUser : IUser
    {
        private readonly IUserRole _iUserRole = new MockUserRole();
        private readonly IUserStatus _iUserStatus = new MockUserStatus();

        public IEnumerable<User> GetUsers
        {
            get
            {
                return new List<User>
                {
                    new User
                    {
                            Id = 1001,
                            FirstName = "Georgii",
                            LastName = "Kotenkov",
                            Email = "veregant@gmail.com",
                            Password = "password",
                            RoleId = 2,
                            StatusId = 2,
                            DateCreate = DateTime.Now,
                            DateModify = DateTime.Now,
                            PointsSummary = 1,
                            UserCreateId = 1,
                            UserUpdateId = 1

                    },
                    new User
                    {

                            Id = 1001,
                            FirstName = "Georgii",
                            LastName = "Kotenkov",
                            Email = "veregant@gmail.com",
                            Password = "password",
                            RoleId = 2,
                            StatusId = 2,
                            DateCreate = DateTime.Now,
                            DateModify = DateTime.Now,
                            PointsSummary = 1,
                            UserCreateId = 1,
                            UserUpdateId = 1

                    }

                };
            }
        }
            

        public IEnumerable<User> GetActiveUsers
        {
            get
            {
                return GetUsers.Where(user =>  user.StatusId == _iUserStatus.GetUserStatuses.Last().Id).ToList();
            }
        }

        public User GetUser(int id)
        {
            return new User { };
        }
    }
}
