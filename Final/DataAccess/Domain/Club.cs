namespace DataAccess.Domain
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public interface IClub
	{
		string ClubId { get; set; }
		string Name { get; set; }
		ICollection<Student> Students { get; set; }
	}

	public partial class Club : IClub
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Club()
        {
            Students = new HashSet<Student>();
        }

        [StringLength(10)]
        public string ClubId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
