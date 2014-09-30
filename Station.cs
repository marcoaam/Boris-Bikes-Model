using System;
using System.Collections;

namespace BorisBikes
{
	public class Station
	{
		public ArrayList Bikes = new ArrayList();

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
			Stack WorkingBikes = new Stack ();
			foreach (Bike bike in Bikes) {
				if(!bike.IsBroken())
					WorkingBikes.Push (bike);
			}
			return WorkingBikes;
		}

		public ArrayList ReleaseAllBrokenBikes()
		{
			ArrayList BrokenBikes = new ArrayList();

			foreach (Bike bike in Bikes) {
				if (bike.IsBroken()) {
					BrokenBikes.Add (bike);
				}
			}
			RemoveBikes (BrokenBikes);
			return BrokenBikes;
		}

		private void RemoveBikes(ArrayList bikes)
		{
			foreach (Bike bike in bikes) { Bikes.Remove (bike); }
		}
	}
}

