using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class ParkingTicket
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public ParkingTicket()
		{
			ParkingDetails = new HashSet<ParkingDetail>();
		}

		[Key]
		[StringLength(10)]
		public string TicketId { get; set; }

		[StringLength(10)]
		public string StudentId { get; set; }

		[StringLength(50)]
		public string OwnerName { get; set; }

		[Column(TypeName = "ntext")]
		public string OwnerAddress { get; set; }

		[StringLength(50)]
		public string VehicleType { get; set; }

		[StringLength(50)]
		public string Color { get; set; }

		[StringLength(20)]
		public string LicensePlates { get; set; }

		[StringLength(20)]
		public string EngineModel { get; set; }

		[StringLength(20)]
		public string ViNumber { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ParkingDetail> ParkingDetails { get; set; }

		public virtual Student Student { get; set; }
	}
}