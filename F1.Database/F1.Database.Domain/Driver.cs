using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Database.Domain
{
    //enum helmet style
    public class Driver : Personnel
    {
        public int DriverNumber { get; set; }

        public Driver(string firstName, string secondName, string occupation, int driverNumber)
            : base(firstName, secondName, occupation)
        {
            DriverNumber = driverNumber;
        }

        public override string GetInfo()
        {
            return $"ID: {ID} | Name: {FirstName} {SecondName} | Occupation: {Occupation} | Driver Number: {DriverNumber}";
        }
    }
}