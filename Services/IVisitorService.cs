using Visitor_Management_System.Entities;

namespace Visitor_Management_System.Services
{
	public interface IVisitorService
	{
		Task<IEnumerable<Visitor>> GetAllVisitorsAsync();
		Task<Visitor> GetVisitorByIdAsync(int id);
		Task<Visitor> AddVisitorAsync(Visitor visitor);
		Task UpdateVisitorAsync(Visitor visitor);
		Task DeleteVisitorAsync(int id);
	}
}
