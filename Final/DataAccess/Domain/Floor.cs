namespace DataAccess.Domain
{
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

	public interface IFloor
	{
		string FloorId { get; set; }
		string BuildingId { get; set; }
		Building Building { get; set; }
		ICollection<Room> Rooms { get; set; }
	}

	public partial class Floor : IFloor
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Floor()
        {
            Rooms = new HashSet<Room>();
        }

        [StringLength(10)]
        public string FloorId { get; set; }

        [StringLength(10)]
        public string BuildingId { get; set; }

        public virtual Building Building { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
