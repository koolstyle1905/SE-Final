using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Tests
{
	public class FakeDbSet<T> : DbSet<T>, IDbSet<T> where T : class
	{
		private readonly List<T> data;

		public FakeDbSet()
		{
			data = new List<T>();
		}

		public FakeDbSet(List<T> data)
		{
			this.data = data;
		}

		public override T Find(params object[] keyValues)
		{
			throw new NotImplementedException("Derive from FakeDbSet<T> and override Find");
		}

		public override T Add(T item)
		{
			data.Add(item);
			return item;
		}

		public override T Remove(T item)
		{
			data.Remove(item);
			return item;
		}

		public override T Attach(T item)
		{
			return null;
		}

		public override T Create()
		{
			return Activator.CreateInstance<T>();
		}

		Type IQueryable.ElementType => data.AsQueryable().ElementType;

		Expression IQueryable.Expression => data.AsQueryable().Expression;

		IQueryProvider IQueryable.Provider => data.AsQueryable().Provider;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return data.GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return data.GetEnumerator();
		}

		public T Detach(T item)
		{
			data.Remove(item);
			return item;
		}

		public override IEnumerable<T> AddRange(IEnumerable<T> entities)
		{
			data.AddRange(entities);
			return data;
		}

		public override IEnumerable<T> RemoveRange(IEnumerable<T> entities)
		{
			var enumerable = entities as IList<T> ?? entities.ToList();
			for (var i = enumerable.Count() - 1; i >= 0; i--)
			{
				var entity = enumerable.ElementAt(i);
				if (data.Contains(entity))
				{
					Remove(entity);
				}
			}
			return this;
		}
	}
}