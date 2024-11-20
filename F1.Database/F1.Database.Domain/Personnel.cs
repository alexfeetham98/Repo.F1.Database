using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace F1.Database.Domain
{
    public enum Occupations
    {
        Driver,
        TeamPrinciple,
        Engineer,
        HeadStrategist,
        TechnicalDirector
    }

    public class Personnel : Entity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Occupation { get; set; }

        public Personnel(string firstName, string secondName, string occupation)
        {
            FirstName = firstName;
            SecondName = secondName;
            Occupation = occupation;
        }
        public virtual string GetInfo()
        {
            return $"ID: {ID} | Full Name: {FirstName} {SecondName} | Occupation: {Occupation}";
        }
    }
}