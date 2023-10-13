using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_13_10.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; }

        public Bicycle(string factoryname, string model, string color, decimal drivetime, decimal drivepath, bool iselectriccar) : base(factoryname, model, color, drivetime, drivepath)
        {
            Type = Type;
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine($"{FactoryName} {Model}- Nature harmness: yoxdu");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Factory name: {FactoryName} Model:{Model} Drive time: {DriveTime} hours/Drive path:{DrivePath} Production date: {ProductionDate}");
        }
    }
}
