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
    public class AddressManager : IAddressService
    {
        IAddressDAL _addressDAL;

        public AddressManager(IAddressDAL addressDAL)
        {
            _addressDAL = addressDAL;
        }

        public void Delete(Address t)
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
            return _addressDAL.GetById(id);
        }

        public List<Address> GetListAll()
        {
            return _addressDAL.GetListAll();
        }

        public void Insert(Address t)
        {
            throw new NotImplementedException();
        }

        public void Update(Address t)
        {
            _addressDAL.Update(t);
        }
    }
}
