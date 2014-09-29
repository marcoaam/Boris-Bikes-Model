using System;

namespace BorisBikes
{
	public class Person
	{
		public object Bike;

		public bool HasBike ()
		{
			return (Bike != null) ? true : false;
		}

		public void RentBikeFrom (object station)
		{
		}
	}
}

