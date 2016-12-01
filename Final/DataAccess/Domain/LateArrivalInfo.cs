using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain
{
	[Table("LateArrivalInfo")]
	public class LateArrivalInfo
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
		public string Description { get; set; }

		public virtual Student Student { get; set; }
	}
}