namespace DataAccess.Domain
{
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

	public interface IPriority
	{
		string PriorityId { get; set; }
		string Content { get; set; }
		ICollection<Student> Students { get; set; }
	}

	public partial class Priority : IPriority
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Priority()
        {
            Students = new HashSet<Student>();
        }

        [StringLength(10)]
        public string PriorityId { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
