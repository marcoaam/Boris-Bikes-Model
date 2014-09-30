using System;

namespace BorisBikes
{
	public class Person
	{
		public object Bike;

		public bool HasBike ()
		{
			return (this.Bike is Bike) ? true : false;
		}

		public void RentBikeFrom (Station station)
		{
			Bike = station.ReleaseBike ();
		}
	}
}

