using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_13_10.Models
{
    internal class Car:Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }

        public Car(string factoryname, string model, string color, decimal drivetime,decimal drivepath,bool iselectriccar) :base(factoryname, model, color, drivetime, drivepath)
        {
            DoorCount = doorcount;
            IsElectricCar = IsElectricCar;
        }

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine($"{FactoryName} {Model}-Nature harmness:Low");
            }
            else
            {
                Console.WriteLine($"{FactoryName} {Model}-Nature harmness:High");
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Factory name: {FactoryName} Model:{Model} Drive time: {DriveTime} hours/Drive path:{DrivePath} Production date: {ProductionDate}");
        }

    }
}
