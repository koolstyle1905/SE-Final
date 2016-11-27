namespace DataAccess.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Text;
	using System.Threading.Tasks;

	public abstract class Repository<TEntity> where TEntity : class
	{
		private readonly DbContext context;

		public Repository(DbContext context)
		{
			this.context = context;
			this.Entities = this.context.Set<TEntity>();
		}

		protected DormitoryContext DormitoryContext
		{
			get
			{
				return this.context as DormitoryContext;
			}
		}

		private DbSet<TEntity> Entities { get; set; }

		public TEntity GetById(string id)
		{
			return this.Entities.Find(id);
		}

		public List<TEntity> ToList()
		{
			return this.Entities.ToList();
		}

		public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
		{
			return this.Entities.Where(predicate);
		}

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return this.Entities.SingleOrDefault(predicate);
		}

		public void Add(TEntity entity)
		{
			this.Entities.Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			this.Entities.AddRange(entities);
		}

		public void Remove(TEntity entity)
		{
			this.Entities.Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			this.Entities.RemoveRange(entities);
		}

		public IEnumerable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> keySelector)
		{
			return this.Entities.OrderBy(keySelector);
		}

		public IEnumerable<TEntity> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> keySelector)
		{
			return this.Entities.OrderByDescending(keySelector);
		}

		public int Count()
		{
			return this.Entities.Count();
		}
	}
}
