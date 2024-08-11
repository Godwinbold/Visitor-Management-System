namespace Visitor_Management_System.Entities
{
	public class Visit
	{
		public int VisitID { get; set; }
		public int VisitorID { get; set; }
		public Visitor Visitor { get; set; }
		public DateTime CheckInTime { get; set; }
		public DateTime? CheckOutTime { get; set; }
		public int PersonVisitedID { get; set; }
		public User PersonVisited { get; set; }
	}
}
