using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	[Table("Attendance")]
	public class Attendance
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Attendance()
		{
			Students = new HashSet<Student>();
		}

		[StringLength(10)]
		public string AttendanceId { get; set; }

		[StringLength(10)]
		public string EmployeeId { get; set; }

		public DateTime CreatedDate { get; set; }

		public virtual Employee Employee { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Student> Students { get; set; }
	}
}