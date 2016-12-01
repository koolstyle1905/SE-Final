namespace DataAccess.Domain
{
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

	public interface IBuilding
	{
		string BuildingId { get; set; }
		ICollection<Floor> Floors { get; set; }
	}

	public partial class Building : IBuilding
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building()
        {
            Floors = new HashSet<Floor>();
        }

        [StringLength(10)]
        public string BuildingId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Floor> Floors { get; set; }
    }
}
