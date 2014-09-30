using NUnit.Framework;
using System.Collections;
using System;

namespace BorisBikes
{
	[TestFixture ()]
	public class VanTest
	{
		private Van van;
		private Station station;
		private Bike broken_bike;
		private Garage garage;

		[SetUp]
		public void init ()
		{
			van = new Van();
			garage = new Garage ();
			station = new Station("Old Street");
			broken_bike = new Bike ();
			broken_bike.Break ();
		}

		[Test ()]
		public void NoBikesWhenCreated ()
		{
			Assert.IsEmpty (van.Bikes);
		}

		[Test()]
		public void CanRequestBikesStation()
		{
			ArrayList bikes = new ArrayList { broken_bike };
			station.Add (bikes);
			van.RequestBrokenBikesFrom (station);
			Assert.IsNotEmpty (van.Bikes);
		}

		[Test()]
		public void CanReleaseBikesToGarage()
		{
			ArrayList bikes = new ArrayList { broken_bike };
			station.Add (bikes);
			van.RequestBrokenBikesFrom (station);
			van.ReleaseBrokenBikes (garage);
			Assert.IsEmpty (van.Bikes);
		}
	}
}

