using GameShop.DataAccess.Data;
using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameShopWeb.Controllers
{
    public class PlatformController : Controller
    {
        private readonly IPlatformRepository _platformRepository;
        public PlatformController(IPlatformRepository db)
        {
			_platformRepository = db;
        }
        public IActionResult Index()
        {
            //Platform情報取得
            List<Platform> objPlatformList = _platformRepository.GetAll().ToList();
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
				_platformRepository.Add(obj);
				//保存
				_platformRepository.Save();
				TempData["success"] = "Platform created successfully";
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
            Platform? platformFromDb = _platformRepository.Get(u=>u.Id==id);
            if(platformFromDb==null)
            {
                return NotFound();
            }
			return View(platformFromDb);
		}
		[HttpPost]
		public IActionResult Edit(Platform obj)
		{
			if (ModelState.IsValid)
			{
				//Platform更新
				_platformRepository.Update(obj);
				//保存
				_platformRepository.Save();
				TempData["success"] = "Platform updated successfully";
				//indexに戻す
				return RedirectToAction("Index");
			}
			return View();
		}
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			Platform? platformFromDb = _platformRepository.Get(u => u.Id == id);
			if (platformFromDb == null)
			{
				return NotFound();
			}
			return View(platformFromDb);
		}
		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePOST(int? id)
		{
			Platform? obj = _platformRepository.Get(u => u.Id == id);
			if (obj == null)
			{
				return NotFound();
			}
			//Platform削除
			_platformRepository.Remove(obj);
			//保存
			_platformRepository.Save();
			TempData["success"] = "Platform deleted successfully";
			//indexに戻す
			return RedirectToAction("Index");
		}
	}
}
