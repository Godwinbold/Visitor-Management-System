namespace Visitor_Management_System.Entities
{
	public class Visitor
	{
		public int VisitorId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public string Purpose { get; set; }
		public DateTime CheckInTime { get; set; }
		public DateTime? CheckOutTime { get; set; }
		public int PersonVisitedId { get; set; }
		public ICollection<Visit> Visits { get; set; }
	}
}
