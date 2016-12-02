using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class Club
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Club()
		{
			Students = new HashSet<Student>();
		}

		[StringLength(10)]
		public string ClubId { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Student> Students { get; set; }
	}
}