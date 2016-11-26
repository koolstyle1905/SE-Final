namespace Business
{
	using System;
	using System.Collections.Generic;
	using AutoMapper;
	using DataAccess.Domain;
	using DataTransfer;

	public class AutoMapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(c =>
			{
				c.CreateMap<Building, BuildingDto>();
				c.CreateMap<Carer, CarerDto>();
				c.CreateMap<Employee, EmployeeDto>();
				c.CreateMap<Floor, FloorDto>();
				c.CreateMap<Student, StudentDto>();

				c.CreateMap<BuildingDto, Building>();
				c.CreateMap<CarerDto, Carer>();
				c.CreateMap<EmployeeDto, Employee>();
				c.CreateMap<StudentDto, Student>();
			});
		}
	}
}
