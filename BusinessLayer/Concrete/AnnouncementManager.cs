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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDAL _announcementDAL;

        public AnnouncementManager(IAnnouncementDAL announcementDAL)
        {
            _announcementDAL = announcementDAL;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _announcementDAL.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announcementDAL.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcement t)
        {
            _announcementDAL.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _announcementDAL.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _announcementDAL.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _announcementDAL.Insert(t);
        }

        public void Update(Announcement t)
        {
            _announcementDAL.Update(t);
        }
    }
}
