namespace DataAccess.Domain
{
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

	public interface IFaculty
	{
		string FacultyId { get; set; }
		string Name { get; set; }
		ICollection<Class> Classes { get; set; }
	}

	public partial class Faculty : IFaculty
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faculty()
        {
            Classes = new HashSet<Class>();
        }

        [StringLength(10)]
        public string FacultyId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
    }
}
