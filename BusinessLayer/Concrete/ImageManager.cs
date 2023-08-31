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
    public class ImageManager : IImageService
    {
        public readonly IImageDAL _imageDAL;

        public ImageManager(IImageDAL imageDAL)
        {
            _imageDAL = imageDAL;
        }

        public void Delete(Image t)
        {
            _imageDAL.Delete(t);
        }

        public Image GetById(int id)
        {
            return _imageDAL.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _imageDAL.GetListAll();
        }

        public void Insert(Image t)
        {
            _imageDAL.Insert(t);
        }

        public void Update(Image t)
        {
            _imageDAL.Update(t);
        }
    }
}
