namespace _04.ClassVehicle
{
    internal class Vehicle
    {
        private string type;
        private string model;
        private Engine engine;
        private double fuel;

        public Vehicle(string type, string model, Engine engine, double fuel)
        {
            Type = type;
            Model = model;
            Engine = engine;
            Fuel = fuel;
        }

        public string Type
        {
            get { return type; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid input!");
                }
                type = value; 
            }
        }

        public string Model
        {
            get { return model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid input!");
                }
                model = value;
            }
        }

        public Engine Engine
        {
            get { return engine; }
            private set 
            {
                if (value == null)
                {
                    Console.WriteLine("Invalid input");
                }
                engine = value; 
            }
        }

        public double Fuel
        {
            get { return fuel; }
            private set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                fuel = value; 
            }
        }

        public double Drive(double number)
        {
            if (fuel - number < 0)
            {
                return 0;
            }
            this.fuel -= number;
            return fuel;
        }

    }
}
