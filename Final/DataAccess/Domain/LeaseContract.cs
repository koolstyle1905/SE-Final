namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeaseContract
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
