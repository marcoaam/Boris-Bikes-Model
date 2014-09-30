using NUnit.Framework;
using System;
using System.Collections;

namespace BorisBikes
{
	[TestFixture ()]
	public class GarageTest
	{
		private Garage garage;
		private Bike broken_bike;

		[SetUp]
		public void init ()
		{
			garage = new Garage();
			broken_bike = new Bike ();
			broken_bike.Break ();
		}

		[Test ()]
		public void NoBikesWhenCreated ()
		{
			Assert.IsEmpty (garage.Bikes);
		}

		[Test()]
		public void CanReceiveGroupOfBikes()
		{
			ArrayList broken_bikes = new ArrayList { broken_bike };
			garage.ReceiveBikes (broken_bikes);
			Assert.IsNotEmpty (garage.Bikes);
		}

		[Test()]
		public void CanFixAllBikes()
		{
			ArrayList broken_bikes = new ArrayList { broken_bike };
			garage.ReceiveBikes (broken_bikes);
			garage.FixBikes ();
			Assert.IsFalse (broken_bike.IsBroken());
		}
	}
}

