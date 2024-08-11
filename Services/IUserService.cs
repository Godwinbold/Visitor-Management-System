using Visitor_Management_System.Entities;

namespace Visitor_Management_System.Services
{
	public interface IUserService
	{
		Task<IEnumerable<User>> GetAllUsersAsync();
		Task<User> GetUserByIdAsync(int id);
		Task<User> AddUserAsync(User user);
		Task UpdateUserAsync(User user);
		Task DeleteUserAsync(int id);
		Task<User> AuthenticateUserAsync(string username, string password);
		string GenerateJwtToken(User user);
	}
}
