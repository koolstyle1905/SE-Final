using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Tests
{
	public class FakeDbSet<T> : IDbSet<T> where T : class
	{
		private readonly List<T> data;

		public FakeDbSet()
		{
			data = new List<T>();
		}

		public FakeDbSet(IEnumerable<T> data)
		{
			this.data = data.ToList();
		}

		#region IDbSet<T> Members

		public T Add(T entity)
		{
			data.Add(entity);
			return entity;
		}

		public T Attach(T entity)
		{
			data.Add(entity);
			return entity;
		}

		public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
		{
			throw new NotImplementedException();
		}

		public T Create()
		{
			throw new NotImplementedException();
		}

		public T Find(params object[] keyValues)
		{
			throw new NotImplementedException();
		}

		public ObservableCollection<T> Local
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public T Remove(T entity)
		{
			data.Remove(entity);
			return entity;
		}

		#endregion

		#region IEnumerable<T> Members

		public IEnumerator<T> GetEnumerator()
		{
			return data.GetEnumerator();
		}

		#endregion

		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			return data.GetEnumerator();
		}

		#endregion

		#region IQueryable Members

		public Type ElementType => data.AsQueryable().ElementType;

		public Expression Expression => data.AsQueryable().Expression;

		public IQueryProvider Provider => data.AsQueryable().Provider;

		#endregion
	}
}