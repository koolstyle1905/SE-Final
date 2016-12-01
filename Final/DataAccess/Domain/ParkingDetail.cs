using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain
{
	public class ParkingDetail
	{
		[Key]
		[Column(Order = 0)]
		[StringLength(10)]
		public string TicketId { get; set; }

		[Key]
		[Column(Order = 1)]
		[StringLength(10)]
		public string EmployeeId { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		[Column(TypeName = "money")]
		public decimal Amount { get; set; }

		public virtual Employee Employee { get; set; }

		public virtual ParkingTicket ParkingTicket { get; set; }
	}
}