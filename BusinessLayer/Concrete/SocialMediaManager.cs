using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void Delete(SocialMedia t)
        {
            _socialMediaDAL.Delete(t);
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDAL.GetById(id);
        }

        public List<SocialMedia> GetListAll()
        {
            return _socialMediaDAL.GetListAll();
        }

        public void Insert(SocialMedia t)
        {
            _socialMediaDAL.Insert(t);
        }

        public void Update(SocialMedia t)
        {
            _socialMediaDAL.Update(t);
        }
    }
}
