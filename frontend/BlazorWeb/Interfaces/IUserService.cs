using BlazorWeb.Models.DataTransferModels;

namespace BlazorWeb.Interfaces
{
	public interface IUserService
	{
		Task<List<UserDT>> GetAllUsersAsync();
		Task AddUser(UserDT userDT);
	}
}
