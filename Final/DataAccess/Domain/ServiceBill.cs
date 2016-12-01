namespace DataAccess.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

	public interface IServiceBill
	{
		string BillId { get; set; }
		string RoomId { get; set; }
		string EmployeeId { get; set; }
		DateTime CreatedDate { get; set; }
		decimal Amount { get; set; }
		Employee Employee { get; set; }
		Room Room { get; set; }
	}

	public partial class ServiceBill : IServiceBill
	{
        [Key]
        [StringLength(10)]
        public string BillId { get; set; }

        [StringLength(10)]
        public string RoomId { get; set; }

        [StringLength(10)]
        public string EmployeeId { get; set; }

        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Room Room { get; set; }
    }
}
