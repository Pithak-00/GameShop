﻿using GameShop.DataAccess.Repository;
using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace GameShopWeb.Areas.Admin.Controllers
{
	public class OrderController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		public OrderController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IActionResult Index() { 
			return View(); 
		}

		#region API CALLS
		[HttpGet]
		public IActionResult GetAll()
		{
			List<OrderHeader> objOrderHeaders = _unitOfWork.OrderHeader.GetAll(includeProperties: "ApplicationUser").ToList();
			return Json(new { data = objOrderHeaders });
		}

		#endregion
	}
}
