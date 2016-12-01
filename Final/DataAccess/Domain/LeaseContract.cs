namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

	public interface ILeaseContract
	{
		string ContractId { get; set; }
		string StudentId { get; set; }
		DateTime CreatedDate { get; set; }
		Student Student { get; set; }
		ICollection<LeaseDetail> LeaseDetails { get; set; }
	}

	public partial class LeaseContract : ILeaseContract
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeaseContract()
        {
            LeaseDetails = new HashSet<LeaseDetail>();
			CreatedDate = DateTime.Now;
        }

        [Key]
        [StringLength(10)]
        public string ContractId { get; set; }

        [StringLength(10)]
        public string StudentId { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Student Student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaseDetail> LeaseDetails { get; set; }
    }
}
