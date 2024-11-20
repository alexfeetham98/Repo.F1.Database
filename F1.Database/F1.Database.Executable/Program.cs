using System;
using System.Text;
using F_.Database.Data.Repository;
using F1.Database.Data;
using F1.Database.Domain;
using Microsoft.Identity.Client;

namespace F1.Database.Executable
{
    class Program
    {
        static void Main()
        {
            var repo = new Repository();

            List<Team> teams = new List<Team>();

            #region Mercedes

            Team mercedes = new Team("Mercedes-AMG PETRONAS F1 Team");
            teams.Add(mercedes);
            mercedes.Address = new Address("Mercedes-Benz Operations Centre", "Lauda Drive", "Brackley", "Northamptonshire", "NN6 9GZ", "UK");

            Driver mercD1 = new Driver("Lewis", "Hamilton", "Driver", 44);
            Driver mercD2 = new Driver("George", "Russell", "Driver", 63);
            mercedes.TeamPersonnel.Add(mercD1);
            mercedes.TeamPersonnel.Add(mercD2);

            Car mercC1 = new Car("W15", Engines.Mercedes, mercD1);
            Car mercC2 = new Car("W15", Engines.Mercedes, mercD2);
            mercedes.Cars.Add(mercC1);
            mercedes.Cars.Add(mercC2);

            Personnel mercP1 = new Personnel("Toto", "Wolff", "Team Principle");
            Personnel mercP2 = new Personnel("Rosie", "Wait", "Head Strategist");
            Personnel mercP3 = new Personnel("James", "Allison", "Technical Director");
            Personnel mercP4 = new Personnel("Peter", "Bonnington", "Race Engineer");
            Personnel mercP5 = new Personnel("Marcus", "Dudley", "Race Engineer");
            Personnel mercP6 = new Personnel("Andrew", "Shovlin", "Chief Engineer");
            mercedes.TeamPersonnel.Add(mercP1);
            mercedes.TeamPersonnel.Add(mercP2);
            mercedes.TeamPersonnel.Add(mercP3);
            mercedes.TeamPersonnel.Add(mercP4);
            mercedes.TeamPersonnel.Add(mercP5);
            mercedes.TeamPersonnel.Add(mercP6);

            #endregion

            #region Ferrari

            Team ferrari = new Team("Scuderia Ferrari HP");
            teams.Add(ferrari);
            ferrari.Address = new Address("Ferrari Factory", "Via Abetone Inferiore 4", "Maranello", "Modena", "41053", "Italy");

            Driver ferrD1 = new Driver("Charles", "Leclerc", "Driver", 16);
            Driver ferrD2 = new Driver("Carlos", "Sainz", "Driver", 55);
            ferrari.TeamPersonnel.Add(ferrD1);
            ferrari.TeamPersonnel.Add(ferrD2);

            Car ferrariC1 = new Car("SF24", Engines.Ferrari, ferrD1);
            Car ferrariC2 = new Car("SF24", Engines.Ferrari, ferrD2);
            ferrari.Cars.Add(ferrariC1);
            ferrari.Cars.Add(ferrariC2);

            Personnel ferrP1 = new Personnel("Fred", "Vasseur", "Team Principle");
            Personnel ferrP2 = new Personnel("Ravin", "Jain", "Head Strategist");
            Personnel ferrP3 = new Personnel("Loic", "Serra", "Technical Director");
            Personnel ferrP4 = new Personnel("Bryan", "Bozzi", "Race Engineer");
            Personnel ferrP5 = new Personnel("Riccardo", "Adami", "Race Engineer");
            Personnel ferrP6 = new Personnel("Matteo", "Togninalli", "Chief Engineer");
            ferrari.TeamPersonnel.Add(ferrP1);
            ferrari.TeamPersonnel.Add(ferrP2);
            ferrari.TeamPersonnel.Add(ferrP3);
            ferrari.TeamPersonnel.Add(ferrP4);
            ferrari.TeamPersonnel.Add(ferrP5);

            #endregion

            #region McLaren

            Team mclaren = new Team("McLaren F1 Team");
            teams.Add(mclaren);
            mclaren.Address = new Address("McLaren Technology Centre", "Chertsey Road", "Woking", "Surrey", "GU21 4YH", "UK");

            Driver mclD1 = new Driver("Lando", "Norris", "Driver", 4);
            Driver mclD2 = new Driver("Oscar", "Piastri", "Driver", 31);
            mclaren.TeamPersonnel.Add(mclD1);
            mclaren.TeamPersonnel.Add(mclD2);

            Car mclC1 = new Car("MCL38", Engines.Mercedes, mclD1);
            Car mclC2 = new Car("MCL38", Engines.Mercedes, mclD2);
            mclaren.Cars.Add(mclC1);
            mclaren.Cars.Add(mclC2);

            Personnel mclP1 = new Personnel("Andrea", "Stella", "Team Principle");
            Personnel mclP2 = new Personnel("Randeep", "Singh", "Head Strategist");
            Personnel mclP3 = new Personnel("Peter", "Prodromou", "Technical Director");
            Personnel mclP4 = new Personnel("Will", "Joseph", "Race Engineer");
            Personnel mclP5 = new Personnel("Tom", "Stallard", "Race Engineer");
            Personnel mclP6 = new Personnel("Rob", "Marshall", "Chief Engineer");
            mclaren.TeamPersonnel.Add(mclP1);
            mclaren.TeamPersonnel.Add(mclP2);
            mclaren.TeamPersonnel.Add(mclP3);
            mclaren.TeamPersonnel.Add(mclP4);
            mclaren.TeamPersonnel.Add(mclP5);
            mclaren.TeamPersonnel.Add(mclP6);

            #endregion

            #region RedBull

            Team redbull = new Team("Oracle Red Bull Racing");
            teams.Add(redbull);
            redbull.Address = new Address("Red Bull Racing Factory", "Bradbourne Drive", "Milton Keynes", "Buckinghamshire", "MK7 8BJ", "UK");

            Driver rbD1 = new Driver("Max", "Verstappen", "Driver", 33);
            Driver rbD2 = new Driver("Sergio", "Perez", "Driver", 11);
            redbull.TeamPersonnel.Add(rbD1);
            redbull.TeamPersonnel.Add(rbD2);

            Car rbC1 = new Car("RBPT24", Engines.RBPT, rbD1);
            Car rbC2 = new Car("RBPT24", Engines.RBPT, rbD2);

            Personnel rbP1 = new Personnel("Christian", "Horner", "Team Principle");
            Personnel rbP2 = new Personnel("Hannah", "Schmitz", "Head Strategist");
            Personnel rbP3 = new Personnel("Adrian", "Newey", "Technical Director");
            Personnel rbP4 = new Personnel("Gianpiero", "Lambiase", "Race Engineer");
            Personnel rbP5 = new Personnel("Hugh", "Bird", "Race Engineer");
            Personnel rbP6 = new Personnel("Paul", "Monaghan", "Chief Engineer");
            redbull.TeamPersonnel.Add(rbP1);
            redbull.TeamPersonnel.Add(rbP2);
            redbull.TeamPersonnel.Add(rbP3);
            redbull.TeamPersonnel.Add(rbP4);
            redbull.TeamPersonnel.Add(rbP5);
            redbull.TeamPersonnel.Add(rbP6);

            #endregion

            repo.AddRange(teams);

            DisplayTeamDataConsole(teams);

        }

        private static void DisplayTeamDataConsole(List<Team> teams)
        {
            for(int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i].GetInfo());
                for(int j = 0; j < teams[i].TeamPersonnel.Count; j++)
                {

                    Console.WriteLine(teams[i].TeamPersonnel[j].GetInfo());
                }
                Console.WriteLine("\n\n");
            }
        }

        public void SaveRepo(Repository repo)
        {
            try
            {
                repo.SaveChanges();
            }
            catch(Exception)
            {

                throw;
            }
        }
    }
}