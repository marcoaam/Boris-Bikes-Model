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

		[SetUp]
		public void init ()
		{
			van = new Van();
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
		public void CanRequestBikesToStation()
		{
			ArrayList bikes = new ArrayList { broken_bike };
			station.Add (bikes);
			van.RequestBrokenBikesFrom (station);
			Assert.IsNotEmpty (van.Bikes);
		}
	}
}

