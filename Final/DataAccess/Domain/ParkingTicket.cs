namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParkingTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParkingTicket()
        {
            ParkingReceipts = new HashSet<ParkingReceipt>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketID { get; set; }

        public int? StudentID { get; set; }

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
        public string VINNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParkingReceipt> ParkingReceipts { get; set; }

        public virtual Student Student { get; set; }
    }
}
