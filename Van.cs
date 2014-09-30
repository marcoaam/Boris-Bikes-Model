using System;
using System.Collections;

namespace BorisBikes
{
	public class Van
	{
		public ArrayList Bikes;

		public Van ()
		{
			Bikes = new ArrayList ();
		}

		public void RequestBrokenBikesFrom(Station station)
		{
			ArrayList BrokenBikes = station.ReleaseAllBrokenBikes ();
			LoadBikes (BrokenBikes);
		}

		private void LoadBikes(ArrayList AllBikes)
		{
			foreach (Bike bike in AllBikes) {
				Bikes.Add (bike);
			}
		}
	}
}

