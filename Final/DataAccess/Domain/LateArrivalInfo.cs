namespace DataAccess.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	[Table("LateArrivalInfo")]
	public partial class LateArrivalInfo
	{
		public LateArrivalInfo()
		{
			CreatedDate = DateTime.Now;
		}
		[Key]
		[StringLength(10)]
		public string LateId { get; set; }

		[StringLength(10)]
		public string StudentId { get; set; }

		[Column(TypeName = "ntext")]
		public string WorkingAddress { get; set; }

		public DateTime ArrivalTime { get; set; }

		public DateTime CreatedDate { get; set; }

		[Column(TypeName = "ntext")]
		public string Reason { get; set; }

		public virtual Student Student { get; set; }
	}
}
