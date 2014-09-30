using NUnit.Framework;
using System.Collections;
using System;

namespace BorisBikes
{
	[TestFixture ()]
	public class StationTest
	{
		[Test ()]
		public void HasNoBikesWhenCreated ()
		{
			Station station = new Station ();
			Assert.IsEmpty (station.Bikes);
		}

		[Test ()]
		public void CanTakeBikes ()
		{
			Bike bike = new Bike();
			ArrayList bikes = new ArrayList { bike };
			Station station = new Station ();
			station.Add (bikes);
			Assert.IsNotEmpty (station.Bikes);
		}

		[Test ()]
		public void CanReleaseBikes ()
		{
			Bike bike = new Bike();
			ArrayList bikes = new ArrayList { bike };
			Station station = new Station ();
			station.Add (bikes);
			station.ReleaseBike ();
			Assert.IsEmpty (station.Bikes);
		}

		[Test ()]
		public void CanReleaseOnlyNonBrokenBikesForRent ()
		{
			Bike bike = new Bike();
			ArrayList bikes = new ArrayList { bike };
			Station station = new Station ();
			station.Add (bikes);
			bike.Break ();
			station.ReleaseBike ();
			Assert.IsNotEmpty (station.Bikes);
		}

		[Test ()]
		public void CanReleaseAllBrokenBikesForRepair ()
		{
			Bike bike = new Bike();
			Bike broken_bike = new Bike ();
			broken_bike.Break ();
			ArrayList bikes = new ArrayList ();
			bikes.Add (bike);
			bikes.Add (broken_bike);
			Station station = new Station ();
			station.Add (bikes);
			station.ReleaseAllBrokenBikes ();

			CollectionAssert.DoesNotContain(station.Bikes, broken_bike );
		}
	}
}

