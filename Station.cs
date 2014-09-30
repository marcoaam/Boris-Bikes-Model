using System;
using System.Collections;

namespace BorisBikes
{
	public class Station
	{
		public Stack Bikes = new Stack();

		public Station ()
		{
		}

		public void Add (ArrayList bikes)
		{
			foreach(object Bike in bikes)
			{
				Bikes.Push (Bike);
			}
		}

		public object ReleaseBike()
		{
			return (Bikes.Count > 0) ? Bikes.Pop () : null;
		}
	}
}

