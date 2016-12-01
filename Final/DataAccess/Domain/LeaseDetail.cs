namespace DataAccess.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

	public interface ILeaseDetail
	{
		string EmployeeId { get; set; }
		string ContractId { get; set; }
		DateTime StartDate { get; set; }
		DateTime EndDate { get; set; }
		decimal? Amount { get; set; }
		Employee Employee { get; set; }
		LeaseContract LeaseContract { get; set; }
	}

	public partial class LeaseDetail : ILeaseDetail
	{
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ContractId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual LeaseContract LeaseContract { get; set; }
    }
}
