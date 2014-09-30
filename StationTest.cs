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
	}
}

