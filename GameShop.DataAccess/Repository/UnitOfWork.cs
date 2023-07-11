using GameShop.DataAccess.Data;
using GameShop.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		ApplicationDbContext _db;
		public IPlatformRepository Platform { get; private set; }
		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			Platform = new PlatformRepository(_db);
		}
		

		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
