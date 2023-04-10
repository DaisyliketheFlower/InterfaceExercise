using System;
namespace InterfaceExercise
{
	public class Suv : IVehicle,ICompany
	{

		public Suv()
		{
			
		}
        public bool HasCargo { get; set;}

        public bool FourWheelDrive { get; set;}

        public bool HasTowHook { get; set; }

        public bool HasSteeringWheel { get; set; }

        public int HowManyWheels { get; set; }

        public bool HasStereo { get; set; }

        public bool HasSunroof { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string CorpName { get; set; }

        public string Motto { get; set; }

    }
}

