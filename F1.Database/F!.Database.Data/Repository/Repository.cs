using F1.Database.Data;
using F1.Database.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_.Database.Data.Repository
{
    public class Repository
    {
        private ApplicationContext _applicationContext { get; set; }

        public Repository()
        {
            _applicationContext = new ApplicationContext();
        }

        public void AddRange(List<Team> Teams)
        {
            _applicationContext.Teams.AddRange(Teams);
        }

        public void SaveChanges()
        {
            _applicationContext.SaveChanges();
        }

        public List<Team> GetTeams()
        {
            return _applicationContext.Teams.ToList();
        }

        public Team Get(int Id)
        {
            return _applicationContext.Teams.SingleOrDefault(x => x.ID == Id);
        }
    }
}