using NUnit.Framework;
using System.Collections;
using System;

namespace BorisBikes
{
	[TestFixture ()]
	public class StationTest
	{
		private Station station;
		private Bike bike;
		private Bike broken_bike;

		[SetUp]
		public void init ()
		{
			bike = new Bike();
			broken_bike = new Bike ();
			broken_bike.Break ();
			station = new Station ("Old Street");
		}

		[Test ()]
		public void GetsCreatedWithName ()
		{
			Assert.AreEqual (station.name, "Old Street");
		}

		[Test ()]
		public void HasNoBikesWhenCreated ()
		{
			Assert.IsEmpty (station.Bikes);
		}

		[Test ()]
		public void CanTakeBikes ()
		{
			ArrayList bikes = new ArrayList { bike };
			station.Add (bikes);
			Assert.IsNotEmpty (station.Bikes);
		}

		[Test ()]
		public void CanReleaseBikes ()
		{
			ArrayList bikes = new ArrayList { bike };
			station.Add (bikes);
			station.ReleaseBike ();
			Assert.IsEmpty (station.Bikes);
		}

		[Test ()]
		public void CanReleaseOnlyNonBrokenBikesForRent ()
		{
			ArrayList bikes = new ArrayList { bike };
			station.Add (bikes);
			bike.Break ();
			station.ReleaseBike ();
			Assert.IsNotEmpty (station.Bikes);
		}

		[Test ()]
		public void CanReleaseAllBrokenBikesForRepair ()
		{
			ArrayList bikes = new ArrayList ();
			bikes.Add (bike);
			bikes.Add (broken_bike);
			station.Add (bikes);
			station.ReleaseAllBrokenBikes ();

			CollectionAssert.DoesNotContain(station.Bikes, broken_bike );
		}
	}
}

