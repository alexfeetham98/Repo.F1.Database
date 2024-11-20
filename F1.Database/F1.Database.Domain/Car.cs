using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Database.Domain
{
    public enum Engines
    {
        Mercedes,
        Ferrari,
        RBPT
    }
    
    //enum livery

    public class Car : Entity
    {
        public Engines Engine { get; set; }
        public string CarName { get; set; }
        public Driver Driver { get; private set; }
             
        public int CarNumnber { get; private set; }
        public Car(string carName, Engines engine, Driver driver)
        {
            CarName = carName;
            Engine = engine;
            Driver = driver;
            CarNumnber = driver.DriverNumber;
        }

        private Car() 
        { 
            //EF
        }

    }
}