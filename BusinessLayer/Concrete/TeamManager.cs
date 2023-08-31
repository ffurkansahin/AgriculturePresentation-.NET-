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
    public class TeamManager : ITeamService
    {
        private readonly ITeamDAL _teamDAL;

        public TeamManager(ITeamDAL teamDAL)
        {
            _teamDAL = teamDAL;
        }

        public void Delete(Team t)
        {
            _teamDAL.Delete(t);
        }

        public Team GetById(int id)
        {
            return _teamDAL.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamDAL.GetListAll();
        }

        public void Insert(Team t)
        {
            _teamDAL.Insert(t);
        }

        public void Update(Team t)
        {
            _teamDAL.Update(t);
        }
    }
}
