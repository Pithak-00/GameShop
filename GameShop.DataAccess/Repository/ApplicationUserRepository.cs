using GameShop.DataAccess.Data;
using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;

namespace GameShop.DataAccess.Repository
{
	public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
		ApplicationDbContext _db;
		public ApplicationUserRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
	}
}
