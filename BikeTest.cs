using NUnit.Framework;
using System;

namespace BorisBikes
{
	[TestFixture ()]
	public class BikeTest
	{
		Bike bike;

		[SetUp]
		public void Init()
		{
			bike = new Bike();
		}

		[Test ()]
		public void IsBikeBroken ()
		{
			Assert.IsFalse(bike.IsBroken());
		}

		[Test ()]
		public void BreakBike ()
		{
			bike.Break();
			Assert.IsTrue(bike.IsBroken());
		}
	}
}

