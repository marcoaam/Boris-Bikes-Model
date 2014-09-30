using NUnit.Framework;
using System.Collections;
using Moq;
using System;

namespace BorisBikes
{
	[TestFixture ()]
	public class PersonTest
	{
		private Person marco;
		private Station station;
		private Bike bike;

		[SetUp]
		public void init()
		{
			marco = new Person ();	
			bike = new Bike();
			station = new Station ("Old Street");
		}

		[Test ()]
		public void HasNoBikeWhenCreated ()
		{
			Assert.IsFalse (marco.HasBike());
		}

		[Test()]
		public void CanRentBikes ()
		{
			ArrayList bikes = new ArrayList { bike };
			station.Add (bikes);

			marco.RentBikeFrom (station);
			Assert.IsTrue (marco.HasBike());
		}
	}
}

