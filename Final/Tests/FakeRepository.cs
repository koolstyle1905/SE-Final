using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using DataAccess;
using DataAccess.Core;
using DataAccess.Domain;
using DataAccess.Repositories;
using NUnit.Framework.Internal;
using Tests;

namespace Tests
{
	public class FakeRepository<T> : IRepository<T> where T : class
	{
		public List<T> Data { get; }

		public FakeRepository()
		{
			Data = new List<T>();
		}

		public FakeRepository(List<T> data)
		{
			this.Data = data;
		}

		public void Add(T entity)
		{
			Data.Add(entity);
		}

		public void AddRange(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		public int Count()
		{
			return Data.Count;
		}

		public void Edit(T entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public T FindById(string id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> GetAll()
		{
			return Data;
		}

		public IEnumerable<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector)
		{
			throw new NotImplementedException();
		}

		public void Remove(T entity)
		{
			throw new NotImplementedException();
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		public T SingleOrDefault(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public List<T> ToList()
		{
			return Data;
		}
	}
}

public class FakeStudentRepository : FakeRepository<Student>, IStudentRepository
{
	public FakeStudentRepository(List<Student> data) : base(data)
	{
	}
}

public class FakeRoomRepository : FakeRepository<Room>, IRoomRepository
{
	public FakeRoomRepository(List<Room> data) : base(data)
	{
	}
}

public class FakeClubRepository : FakeRepository<Club>, IClubRepository
{
	public FakeClubRepository(List<Club> data) : base(data)
	{
	}
}

public class FakeEmployeeRepository : FakeRepository<Employee>
{
	public FakeEmployeeRepository(List<Employee> data) : base(data)
	{
	}
}