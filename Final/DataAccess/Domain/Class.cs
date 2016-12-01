namespace DataAccess.Domain
{
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

	public interface IClass
	{
		string ClassId { get; set; }
		string FacultyId { get; set; }
		Faculty Faculty { get; set; }
		ICollection<Student> Students { get; set; }
	}

	public partial class Class : IClass
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            Students = new HashSet<Student>();
        }

        [StringLength(10)]
        public string ClassId { get; set; }

        [StringLength(10)]
        public string FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
