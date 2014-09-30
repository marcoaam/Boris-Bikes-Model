using System;

namespace BorisBikes
{
	public class Bike
	{
		private bool Broken = false;

		public bool IsBroken()
		{
			return Broken;
		}

		public void Break()
		{
			Broken = true;
		}

		public void Fix()
		{
			Broken = false;
		}
	}
}

