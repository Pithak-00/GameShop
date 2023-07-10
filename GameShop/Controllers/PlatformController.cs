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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Platform obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                //新規Platform作成
                _db.Platforms.Add(obj);
                //保存
                _db.SaveChanges();
				//indexに戻す
				return RedirectToAction("Index");
			}
           return View();
        }
		public IActionResult Edit(int? id)
		{
            if(id==null || id == 0)
            {
                return NotFound();
            }
            Platform? platformFromDb = _db.Platforms.Find(id);
            if(platformFromDb==null)
            {
                return NotFound();
            }
			return View(platformFromDb);
		}
		[HttpPost]
		public IActionResult Edit(Platform obj)
		{
			if (obj.Name == obj.DisplayOrder.ToString())
			{
				ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
			}
			if (ModelState.IsValid)
			{
				//新規Platform作成
				_db.Platforms.Add(obj);
				//保存
				_db.SaveChanges();
				//indexに戻す
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
