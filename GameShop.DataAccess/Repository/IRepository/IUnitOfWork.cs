using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		IPlatformRepository Platform { get; }
		IProductRepository Product { get; }
		void Save();
	}
}
