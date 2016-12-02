using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using DataAccess.Core;
using DataAccess.Domain;
using DataAccess.Repositories;
using NUnit.Framework.Internal;

namespace Tests
{
	public class FakeRepository<T> : IRepository<T> where T : class
	{
		private readonly List<T> data;

		public FakeRepository()
		{
			data = new List<T>();
		}

		public FakeRepository(List<T> data)
		{
			this.data = data;
		}

		public void Add(T entity)
		{
			data.Add(entity);
		}

		public void AddRange(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		public int Count()
		{
			return data.Count;
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
			return data;
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
			return data;
		}
	}
}

public class FakeStudentRepository : Repository<Student>, IStudentRepository
{
	public FakeStudentRepository(DbContext context) : base(context)
	{
	}
}
