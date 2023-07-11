using GameShop.Models;

namespace GameShop.DataAccess.Repository.IRepository
{
	public interface IPlatformRepository : IRepository<Platform>
	{
		void Update(Platform obj);
	}
}
