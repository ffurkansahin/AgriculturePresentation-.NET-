using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDAL _aboutDAL;

		public AboutManager(IAboutDAL aboutDAL)
		{
			_aboutDAL = aboutDAL;
		}

		public void Delete(About t)
		{
			_aboutDAL.Delete(t);
		}

		public About GetById(int id)
		{
			return _aboutDAL.GetById(id);
		}

		public List<About> GetListAll()
		{
			return _aboutDAL.GetListAll();
		}

		public void Insert(About t)
		{
			_aboutDAL.Insert(t);
		}

		public void Update(About t)
		{
			_aboutDAL.Update(t);
		}
	}
}
