namespace DataAccess.Domain
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public interface ILateArrivalInfo
	{
		string LateId { get; set; }
		string StudentId { get; set; }
		string WorkingAddress { get; set; }
		DateTime ArrivalTime { get; set; }
		DateTime CreatedDate { get; set; }
		string Reason { get; set; }
		Student Student { get; set; }
	}

	[Table("LateArrivalInfo")]
	public partial class LateArrivalInfo : ILateArrivalInfo
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
