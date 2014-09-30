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
		public void NotBrokenWhenCreated ()
		{
			Assert.IsFalse(bike.IsBroken());
		}

		[Test ()]
		public void CanBeBroken ()
		{
			bike.Break();
			Assert.IsTrue(bike.IsBroken());
		}

		[Test ()]
		public void CanBeFixed ()
		{
			bike.Break ();
			bike.Fix ();
			Assert.IsFalse (bike.IsBroken ());
		}
	}
}

