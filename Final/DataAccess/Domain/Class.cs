using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class Class
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Class()
		{
			Students = new HashSet<Student>();
		}

		[StringLength(10)]
		public string ClassId { get; set; }

		[StringLength(10)]
		public string FacultyId { get; set; }

		public virtual Faculty Faculty { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Student> Students { get; set; }
	}
}