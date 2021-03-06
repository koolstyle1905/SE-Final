﻿using AutoMapper;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class AutoMapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(c =>
			{
				c.CreateMap<Building, BuildingDto>();
				c.CreateMap<Carer, CarerDto>();
				c.CreateMap<Club, ClubDto>();
				c.CreateMap<Employee, EmployeeDto>();
				c.CreateMap<Floor, FloorDto>();
				c.CreateMap<Room, RoomDto>();
				c.CreateMap<Student, StudentDto>();
				c.CreateMap<Priority, PriorityDto>();
				c.CreateMap<Class, ClassDto>();
				c.CreateMap<Faculty, FacultyDto>();
				c.CreateMap<TemporaryAbsence, TemporaryAbsenceDto>();
				c.CreateMap<ReportAbsence, ReportAbsenceDto>();
				c.CreateMap<ViolationRecord, ViolationRecordDto>();
				c.CreateMap<LateArrivalInfo, LateArrivalDto>();

				c.CreateMap<BuildingDto, Building>();
				c.CreateMap<CarerDto, Carer>();
				c.CreateMap<ClubDto, Club>();
				c.CreateMap<EmployeeDto, Employee>();
				c.CreateMap<StudentDto, Student>()
					.ForMember(d => d.ClassId, o => o.MapFrom(s => s.Class.ClassId));
				c.CreateMap<PriorityDto, Priority>();
				c.CreateMap<ClassDto, Class>();
				c.CreateMap<FacultyDto, Faculty>();
				c.CreateMap<TemporaryAbsenceDto, TemporaryAbsence>();
			});
		}
	}
}