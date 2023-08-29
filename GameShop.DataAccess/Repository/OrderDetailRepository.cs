using GameShop.DataAccess.Data;
using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;

namespace GameShop.DataAccess.Repository
{
	public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
		ApplicationDbContext _db;
		public OrderDetailRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
		public void Update(OrderDetail obj)
		{
			_db.OrderDetails.Update(obj);
		}
	}
}
