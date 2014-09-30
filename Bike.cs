using System;

namespace BorisBikes
{
	public class Bike
	{
		private bool Broken = false;

		public bool IsBroken()
		{
			return this.Broken;
		}

		public void Break()
		{
			this.Broken = true;
		}
	}
}

