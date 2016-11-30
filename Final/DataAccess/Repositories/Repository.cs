﻿namespace DataAccess.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Text;
	using System.Threading.Tasks;
	using Core;

	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		private readonly DbContext context;

		protected Repository(DbContext context)
		{
			this.context = context;
			DbSet = this.context.Set<TEntity>();
		}

		protected DbSet<TEntity> DbSet { get; }

		public TEntity FindById(string id)
		{
			return DbSet.Find(id);
		}

		public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.Where(predicate);
		}

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.SingleOrDefault(predicate);
		}

		public void Add(TEntity entity)
		{
			DbSet.Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			DbSet.AddRange(entities);
		}

		public void Remove(TEntity entity)
		{
			DbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			DbSet.RemoveRange(entities);
		}

		public void Edit(TEntity entity)
		{
			context.Entry(entity).State = EntityState.Modified;
		}

		public IEnumerable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> keySelector)
		{
			return DbSet.OrderBy(keySelector);
		}

		public IEnumerable<TEntity> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> keySelector)
		{
			return DbSet.OrderByDescending(keySelector);
		}

		public int Count()
		{
			return DbSet.Count();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return DbSet.AsEnumerable();
		}

		public List<TEntity> ToList()
		{
			return DbSet.ToList();
		}
	}
}
