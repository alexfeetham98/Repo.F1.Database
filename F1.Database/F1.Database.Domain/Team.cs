using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Database.Domain
{
    public enum TeamNames
    {
        Mercedes,
        Ferrari,
        RedBullRacing,
        McLaren,
        Alpine,
        AstonMartin,
        AlphaTauri,
        Sauber,
        Haas,
        Williams
    }
    public class Team : Entity
    {
        public string TeamName { get; set; }
        public List<Car> Cars { get; set; }
        public List<Personnel> TeamPersonnel { get; set; }
        public Address Address { get; set; }

        public Team(string teamName)
        {
            TeamName = teamName;
            Cars = new List<Car>();
            TeamPersonnel = new List<Personnel>();
        }

        public string GetInfo()
        {
            return $"ID: {ID} | Team Name: {TeamName} | Address: {Address}";
        }
    }
}