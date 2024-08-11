using Visitor_Management_System.Entities;

namespace Visitor_Management_System.Services
{
	public interface IVisitService
	{
		Task<IEnumerable<Visit>> GetAllVisitsAsync();
		Task<Visit> GetVisitByIdAsync(int id);
		Task<Visit> AddVisitAsync(Visit visit);
		Task UpdateVisitAsync(Visit visit);
		Task DeleteVisitAsync(int id);
	}
}
