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
			foreach(object bike in bikes)
			{
				Bikes.Push (bike);
			}
		}

		public object ReleaseBike()
		{
			return Bikes.Pop ();
		}
	}
}

