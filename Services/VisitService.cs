using Microsoft.EntityFrameworkCore;
using Visitor_Management_System.Data;
using Visitor_Management_System.Entities;

namespace Visitor_Management_System.Services
{
	public class VisitService : IVisitService
	{
		private readonly ApplicationDbContext _context;

		public VisitService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Visit>> GetAllVisitsAsync()
		{
			return await _context.Visits.ToListAsync();
		}
		public async Task<Visit> AddVisitAsync(Visit visit)
		{
			_context.Visits.Add(visit);
			await _context.SaveChangesAsync();
			return visit;
		}

		public async Task<Visit> GetVisitByIdAsync(int id)
		{
			return await _context.Visits.FindAsync(id);
		}

		public async Task UpdateVisitAsync(Visit visit)
		{
			_context.Entry(visit).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}

		public async Task DeleteVisitAsync(int id)
		{
			var visit = await _context.Visits.FindAsync(id);
			if (visit != null)
			{
				_context.Visits.Remove(visit);
				await _context.SaveChangesAsync();
			}
		}
	}
}
