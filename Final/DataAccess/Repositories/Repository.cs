namespace DataAccess.Repositories
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
		protected DbSet<TEntity> dbSet;
	
		public Repository(DbContext context)
		{
			this.context = context;
			this.dbSet = this.context.Set<TEntity>();
		}

		public TEntity FindById(string id)
		{
			return this.dbSet.Find(id);
		}

		public List<TEntity> ToList()
		{
			return this.dbSet.ToList();
		}

		public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
		{
			return this.dbSet.Where(predicate);
		}

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return this.dbSet.SingleOrDefault(predicate);
		}

		public void Add(TEntity entity)
		{
			this.dbSet.Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			this.dbSet.AddRange(entities);
		}

		public void Remove(TEntity entity)
		{
			this.dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			this.dbSet.RemoveRange(entities);
		}

		public virtual void Edit(TEntity entity)
		{
			this.context.Entry(entity).State = EntityState.Modified;
		}

		public IEnumerable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> keySelector)
		{
			return this.dbSet.OrderBy(keySelector);
		}

		public IEnumerable<TEntity> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> keySelector)
		{
			return this.dbSet.OrderByDescending(keySelector);
		}

		public int Count()
		{
			return this.dbSet.Count();
		}
	}
}
