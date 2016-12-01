using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class LeaseContract
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public LeaseContract()
		{
			LeaseDetails = new HashSet<LeaseDetail>();
		}

		[Key]
		[StringLength(10)]
		public string ContractId { get; set; }

		[StringLength(10)]
		public string StudentId { get; set; }

		public DateTime CreatedDate { get; set; }

		public virtual Student Student { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<LeaseDetail> LeaseDetails { get; set; }
	}
}