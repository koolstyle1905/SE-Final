using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class Floor
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Floor()
		{
			Rooms = new HashSet<Room>();
		}

		[StringLength(10)]
		public string FloorId { get; set; }

		[StringLength(10)]
		public string BuildingId { get; set; }

		public virtual Building Building { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Room> Rooms { get; set; }
	}
}