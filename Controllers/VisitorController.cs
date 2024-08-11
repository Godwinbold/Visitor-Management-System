using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Visitor_Management_System.Entities;
using Visitor_Management_System.Services;

namespace Visitor_Management_System.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VisitorController : ControllerBase
	{
		private readonly IVisitorService _visitorService;
		public VisitorController(IVisitorService visitorService) 
		{
			_visitorService = visitorService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllVisitor()
		{
			var visitors = await _visitorService.GetAllVisitorsAsync();
			return Ok(visitors);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult>GetVisitorById(int id)
		{
			var visitor = await _visitorService.GetVisitorByIdAsync(id);
			if(visitor == null) return NotFound();
			return Ok(visitor);
		}

		[HttpPost]
		public async Task<IActionResult> CreateVisitor([FromBody] Visitor visitor)
		{
			var visitors = await _visitorService.AddVisitorAsync(visitor);
			return CreatedAtAction(nameof(GetVisitorById), new { id = createdVisitor.VisitorId }, createdVisitor);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateVisitor(int id, [FromBody] Visitor visitor)
		{
			if(id != visitor.VisitorId) return BadRequest();
			await _visitorService.UpdateVisitorAsync(visitor);
			return NoContent();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteVisitor(int id)
		{
			await _visitorService.DeleteVisitorAsync(id);
			return NoContent();
		}
	}
}
