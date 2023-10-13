using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_13_10.Models
{
    internal abstract class Vehicle
    {

        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal DriveTime { get; set; }
        public decimal DrivePath { get; set; }
        public DateTime ProductionDate { get; }

        public Vehicle(string factoryName, string model, string color, decimal driveTime, decimal drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
            ProductionDate = DateTime.Now;

        }

        public decimal AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory name: {FactoryName} Model:{Model} Drive time: {DriveTime} hours/Drive path:{DrivePath} Production date: {ProductionDate}");
        }

        public abstract void DefineNatureHarmness();
        public override string ToString()
        {
            return $"{FactoryName} - {Model}";
        }
    }
}
