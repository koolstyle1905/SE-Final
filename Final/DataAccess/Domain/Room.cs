namespace DataAccess.Domain
{
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

	public interface IRoom
	{
		string RoomId { get; set; }
		string FloorId { get; set; }
		Floor Floor { get; set; }
		ICollection<ServiceBill> ServiceBills { get; set; }
		ICollection<Student> Students { get; set; }
	}

	public partial class Room : IRoom
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            ServiceBills = new HashSet<ServiceBill>();
            Students = new HashSet<Student>();
        }

        [StringLength(10)]
        public string RoomId { get; set; }

        [StringLength(10)]
        public string FloorId { get; set; }

        public virtual Floor Floor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceBill> ServiceBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
