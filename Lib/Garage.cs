using System;
using System.Collections;

namespace BorisBikes
{
	public class Garage
	{
		public ArrayList Bikes;

		public Garage ()
		{
			Bikes = new ArrayList ();
		}

		public void ReceiveBikes(ArrayList bikes)
		{
			foreach (Bike bike in bikes) { Bikes.Add (bike); }
		}

		public void FixBikes()
		{
			foreach (Bike bike in Bikes) {
				bike.Fix ();
			}
		}

		public ArrayList ReleaseWorkingBikes()
		{
			ArrayList WorkingBikes = new ArrayList();
			foreach (Bike bike in Bikes) {
				if (!bike.IsBroken()) {
					WorkingBikes.Add (bike);
				}
			}
			return WorkingBikes;
		}
	}
}

