using GameShop.DataAccess.Data;
using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;

namespace GameShop.DataAccess.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
		public void Update(Product obj)
		{
			_db.Products.Update(obj);
		}
	}
}
