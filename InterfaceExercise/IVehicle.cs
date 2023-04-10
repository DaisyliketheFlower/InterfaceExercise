using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public bool HasSteeringWheel { get; set; }

		public int HowManyWheels { get; set; }

		public bool HasStereo { get; set; }

		public bool HasSunroof { get; set;}

		public int Year { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }
	}
}

