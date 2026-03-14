using System;

namespace Task1
{
	public class Fridge : OnOff
	{
		internal string modelName;
		
		public void On()
		{
			Console.Write($"Fridge '{modelName}' turned on");
		}

		public void Off()
		{
			Console.Write($"Fridge '{modelName}' turned off");
		}
	}
}
