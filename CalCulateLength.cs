using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
	public class Sample
	{

		public static void CaluculateRoot()
		{

			// point 1
			double x1 =1;
			double y1 =2;

			// point 2
			double x2=5;
			double y2=5;

			// Calculate distance between two points
			double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1)
					* (y2 - y1));

			Console.WriteLine("Distance between two points :" + distance);
		}

	}
}
