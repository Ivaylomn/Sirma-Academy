namespace _04.ClassVehicle
{
    internal class Engine
    {
		private int power;

		public int Power
		{
			get { return power; }
			internal set 
			{
				if (value <= 0)
				{
                    Console.WriteLine("Invalid Power");
				}

				power = value; 
			}
		}

	}
}
