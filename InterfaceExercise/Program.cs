using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();

            var sedan1 = new Car()
            {
                Year = 2018,
                Make = "Honda",
                Model = "Accord",
                CorpName = "BrandX",
                HasLeatherSeats = true,
                HasSteeringWheel = true,
                HasStereo = true,
                HasSunroof = true,
                HasTrunk = true,
                HowManyWheels = -4,
                Motto = "Best Brand X Ever !"
            };

            var Truck1 = new Truck()
            {
                Year = 1980,
                Make = "Ford",
                Model = "F-150",
                HasSteeringWheel = true,
                HasTowHook = true,
                HasSunroof = false,
                HasStereo = false,
                HowManyWheels = 4,
                TruckBed = true,
                CorpName = "Landscarpers Inc",
                Motto = "Trimming hedges"
            };
            var suv1 = new Suv()
            {
                Year = 2020,
                Make = "Jeep",
                Model = "Wrangler unlimited",
                FourWheelDrive = true,
                HasCargo = true,
                HasSteeringWheel = true,
                HasStereo = true,
                HasSunroof = true,
                HowManyWheels = 4,
                CorpName = "C001 333ps",
                Motto = "Goin Muddin"
            };

            vehicles.Add(sedan1);
            vehicles.Add(Truck1);
            vehicles.Add(suv1);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Year:{veh.Year},Make:{veh.Make},Model: {veh.Model}");
                Console.WriteLine($"Stereo?: {veh.HasStereo}, # of wheels: {veh.HowManyWheels}\n");
            }
        }
    }
}
