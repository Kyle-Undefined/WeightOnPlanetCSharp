using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeightOnPlanetCSharp
{
	class Program
	{

		private static Dictionary<string, decimal> _planets = new Dictionary<string, decimal>();

		public static void Main(string[] args)
		{
			string _planet = null;
			decimal _weight = default(decimal);

			_planets.Add("MERCURY", Convert.ToDecimal(0.4155));
			_planets.Add("VENUS", Convert.ToDecimal(0.8975));
			_planets.Add("EARTH", Convert.ToDecimal(1.0));
			_planets.Add("MARS", Convert.ToDecimal(0.3507));
			_planets.Add("JUPITER", Convert.ToDecimal(2.5374));
			_planets.Add("SATURN", Convert.ToDecimal(1.0677));
			_planets.Add("URANUS", Convert.ToDecimal(0.8947));
			_planets.Add("NEPTUNE", Convert.ToDecimal(1.1794));
			_planets.Add("PLUTO", Convert.ToDecimal(0.0899));

			Console.Write("Please Enter a Planet Name: ");
			_planet = Console.ReadLine().ToUpper();

			Console.Write("Please Enter Your Weight: ");
			try
			{
				_weight = Convert.ToDecimal(Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("Error, defaulting weight to 0.0");
				_weight = Convert.ToDecimal(0.0);
			}

			foreach (KeyValuePair<string, decimal> pair in _planets)
			{
				if (_planet == pair.Key)
				{
					Console.WriteLine("Your weight on " + pair.Key + " is " + Convert.ToString(_weight * pair.Value));
				}
			}

			Console.WriteLine();
			Console.Write("Press any key to Exit...");
			Console.ReadLine();
		}
	}
}
