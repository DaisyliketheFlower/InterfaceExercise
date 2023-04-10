using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
	
        public Truck()

		{
			
		}
        public bool TruckBed { get; internal set; } 

        public bool HasTowHook { get; set; }

        public bool HasSteeringWheel { get; set; }

        public int HowManyWheels { get; set; }

        public bool HasStereo { get; set; }

        public bool HasSunroof { get; internal set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string CorpName { get; set; }

        public string Motto { get; set; }





