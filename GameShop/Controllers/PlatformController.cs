using GameShop.DataAccess.Data;
using GameShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameShopWeb.Controllers
{
    public class PlatformController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PlatformController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //Platform情報取得
            List<Platform> objPlatformList = _db.Platforms.ToList();
			//Platform情報表示
			return View(objPlatformList);
        }
    }
}
