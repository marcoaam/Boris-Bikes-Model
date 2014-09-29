using NUnit.Framework;
using Moq;
using System;

namespace BorisBikes
{
	[TestFixture ()]
	public class PersonTest
	{
		[Test ()]
		public void HasNoBike ()
		{
			Person marco = new Person ();
			Assert.IsFalse (marco.HasBike());
		}

		[Test()]
		public void HasBike ()
		{
		}
	}
}

