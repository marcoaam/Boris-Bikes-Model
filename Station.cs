using System;
using System.Collections;

namespace BorisBikes
{
	public class Station
	{
		public ArrayList Bikes = new ArrayList();
		private Stack WorkingBikes = new Stack ();

		public Station ()
		{
		}

		public void Add (ArrayList bikes)
		{
			foreach(object Bike in bikes) { Bikes.Add (Bike); }
		}

		public object ReleaseBike()
		{
			if (GetWorkingBikes().Count > 0)
			{
				var bike = GetWorkingBikes ().Pop ();
				Bikes.Remove (bike);
				return bike;
			}

			else {
				return null;
			}
		}

		private Stack GetWorkingBikes ()
		{
			foreach (Bike bike in Bikes) 
			{
				if(!bike.IsBroken())
					this.WorkingBikes.Push (bike);
			}
			return this.WorkingBikes;
		}
	}
}

