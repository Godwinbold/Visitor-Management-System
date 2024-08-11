using Microsoft.AspNetCore.Mvc;
using Visitor_Management_System.Data;
using Visitor_Management_System.Entities;
using Visitor_Management_System.Services;

namespace Visitor_Management_System.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllUsers()
		{
			var users = await _userService.GetAllUsersAsync();
			return Ok(users);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetUserById(int id)
		{
			var user = await _userService.GetUserByIdAsync(id);
			if (user == null) return NotFound();
			return Ok(user);
		}
		[HttpPost]
		public async Task<IActionResult> CreateUser([FromBody] User user)
		{
			var CreateUser = await _userService.AddUserAsync(user);
			return CreatedAtAction(nameof(GetUserById), new { id = createdUser.UserId }, createdUser);

		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
		{
			if(id != user.UserId) return BadRequest();
			await _userService.UpdateUserAsync(user);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUser(int id)
		{
			await _userService.DeleteUserAsync(id);
			return NoContent();
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] User user)
		{
			var dbUser = await _userService.AuthenticateUserAsync(user.Username, user.Password);
			if(dbUser == null) return Unauthorized();
			var token = _userService.GenerateJwtToken(dbUser);
			return Ok(new { token = token });
		}
	}
}
