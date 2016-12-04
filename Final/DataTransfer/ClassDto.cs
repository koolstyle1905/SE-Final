using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	public class ClassDto
	{
		public string ClassId { get; set; }
		
		public string FacultyId { get; set; }

		public FacultyDto Faculty { get; set; }
	}
}
