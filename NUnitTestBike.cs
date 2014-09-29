using NUnit.Framework;
using System;

namespace BorisBikes
{
	[TestFixture ()]
	public class NUnitTestBike
	{
		[Test ()]
		public void IsBikeBroken ()
		{
			Bike bike = new Bike ();
			Assert.IsFalse(bike.IsBroken());
		}

		[Test ()]
		public void BreakBike ()
		{
			Bike bike = new Bike ();
			bike.Break();
			Assert.IsTrue(bike.IsBroken());
		}
	}
}

