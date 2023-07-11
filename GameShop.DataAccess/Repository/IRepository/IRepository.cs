using System.Linq.Expressions;

namespace GameShop.DataAccess.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
		//T - Platform
		IEnumerable<T> GetAll();
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
	}
}
