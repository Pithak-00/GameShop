﻿using GameShop.DataAccess.Data;
using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;

namespace GameShop.DataAccess.Repository
{
	public class PlatformRepository : Repository<Platform>, IPlatformRepository
	{
		ApplicationDbContext _db;
		public PlatformRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
		public void Update(Platform obj)
		{
			_db.Platforms.Update(obj);
		}
	}
}
