using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class Faculty
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Faculty()
		{
			Classes = new HashSet<Class>();
		}

		[StringLength(10)]
		public string FacultyId { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Class> Classes { get; set; }
	}
}