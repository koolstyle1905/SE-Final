namespace DataAccess.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using AutoMapper;
	using Domain;

	public class StudentRepository : Repository<Student>
	{
		public StudentRepository(DbContext context) : base(context)
		{
		}

		//public void Edit(Student student)
		//{
		//	var s = this.DbSet.Find(student.StudentID);
		//	s.StudentID = "1";
		//} 
	}
}
