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

		[SetUp]
		public void init()
		{
			marco = new Person ();	
		}

		[Test ()]
		public void HasNoBike ()
		{
			Assert.IsFalse (marco.HasBike());
		}

		[Test()]
		public void HasBike ()
		{
			var bike = new Bike ();
			var station = new Station ();
			ArrayList bikes = new ArrayList { bike };
			station.Add (bikes);

			marco.RentBikeFrom (station);
			Assert.IsTrue (marco.HasBike());
		}
	}
}

