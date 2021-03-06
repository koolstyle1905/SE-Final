﻿using System.Collections.Generic;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class FacultyBusiness
	{
		public static List<FacultyDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var facultyList = unitOfWork.Faculties.ToList();
				return Mapper.Map<List<Faculty>, List<FacultyDto>>(facultyList);
			}
		}
	}
}