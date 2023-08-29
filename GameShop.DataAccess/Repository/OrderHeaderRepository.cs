using GameShop.DataAccess.Data;
using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;

namespace GameShop.DataAccess.Repository
{
	public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
		ApplicationDbContext _db;
		public OrderHeaderRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
		public void Update(OrderHeader obj)
		{
			_db.OrderHeaders.Update(obj);
		}
	}
}
