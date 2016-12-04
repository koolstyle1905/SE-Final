namespace DataTransfer
{
	public class ClassDto
	{
		public string ClassId { get; set; }

		public string FacultyId { get; set; }

		public FacultyDto Faculty { get; set; }
	}
}