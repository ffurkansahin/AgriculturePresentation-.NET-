using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AdminManager : IAdminService
	{
		IAdminDAL _adminDAL;

		public AdminManager(IAdminDAL adminDAL)
		{
			_adminDAL = adminDAL;
		}

		public void Delete(Admin t)
		{
			_adminDAL.Delete(t);
		}

		public Admin GetById(int id)
		{
			return _adminDAL.GetById(id);
		}

		public List<Admin> GetListAll()
		{
			return _adminDAL.GetListAll();
		}

		public void Insert(Admin t)
		{
			_adminDAL.Insert(t);
		}

		public void Update(Admin t)
		{
			_adminDAL.Update(t);
		}
	}
}
