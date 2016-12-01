namespace DataAccess.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

	public interface IParkingDetail
	{
		string TicketId { get; set; }
		string EmployeeId { get; set; }
		DateTime StartDate { get; set; }
		DateTime EndDate { get; set; }
		decimal Amount { get; set; }
		Employee Employee { get; set; }
		ParkingTicket ParkingTicket { get; set; }
	}

	public partial class ParkingDetail : IParkingDetail
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
