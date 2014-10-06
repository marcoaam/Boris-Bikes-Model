using System;
using System.Collections;

namespace BorisBikes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Station station = new Station ("Old Street");
			ArrayList bikes = new ArrayList ();
			int x = 0;
			for (x = 1 ; x < 20; x++) {
				bikes.Add (new Bike ());
			}

			foreach (Bike bike in bikes) { bike.Break; }
			station.Add (bikes);
			Console.WriteLine ();
			Person marco = new Person ();
			Console.WriteLine (station.Bikes.Count);

			Console.WriteLine (marco.HasBike());
			marco.RentBikeFrom (station);
			Console.WriteLine (marco.HasBike ());
			Console.WriteLine (marco.Bike);
			Console.ReadLine ();
		}
	}
}
