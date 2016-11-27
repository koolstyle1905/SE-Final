namespace DataAccess.Core
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public interface IRepository<TEntity> where TEntity : class
	{
		void Add(TEntity entity);

		void AddRange(IEnumerable<TEntity> entities);

		int Count();

		void Edit(TEntity entity);

		IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

		TEntity FindById(string id);

		IEnumerable<TEntity> GetAll();

		IEnumerable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> keySelector);

		IEnumerable<TEntity> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> keySelector);

		void Remove(TEntity entity);

		void RemoveRange(IEnumerable<TEntity> entities);

		TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

		List<TEntity> ToList();
	}
}