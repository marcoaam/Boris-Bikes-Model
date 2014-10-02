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

		public void ReleaseBrokenBikes(Garage garage)
		{
			ArrayList OnlyBrokenBikes = new ArrayList(BrokenBikes ());
			garage.ReceiveBikes (OnlyBrokenBikes);
			RemoveBikes(OnlyBrokenBikes);
		}

		private void LoadBikes(ArrayList AllBikes)
		{
			foreach (Bike bike in AllBikes) {
				Bikes.Add (bike);
			}
		}

		private void RemoveBikes(ArrayList bikes)
		{
			foreach (Bike bike in bikes) { Bikes.Remove (bike); }
		}

		private ArrayList BrokenBikes()
		{
			ArrayList BrokenBikes = new ArrayList();
			foreach (Bike bike in Bikes) {
				if (bike.IsBroken()) {
					BrokenBikes.Add (bike);
				}
			}
			return BrokenBikes;
		}

		private ArrayList GetWorkingBikes()
		{
			ArrayList WorkingBikes = new ArrayList();
			foreach (Bike bike in Bikes) {
				if (bike.IsBroken()) {
					WorkingBikes.Add (bike);
				}
			}
			return WorkingBikes;
		}

		public void RequestWorkingBikesFrom(Garage garage)
		{
			ArrayList WorkingBikes = garage.ReleaseWorkingBikes ();
			LoadBikes (WorkingBikes);
		}

		public void ReleaseWorkingBikesTo (Station station)
		{
			station.ReceiveWorkingBikes (GetWorkingBikes());
			RemoveBikes (GetWorkingBikes ());
		}
			
	}
}

