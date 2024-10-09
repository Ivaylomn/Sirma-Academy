namespace _02.CarConstructors
{
    internal class Car
    {
        private string brand;
        private string model;
        private int horsePower;

        public Car(string brand)
        {
            Brand = brand;
            Model = "";
            HorsePower = 0;
        }

        public Car(string brand, string model, int horesPower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horesPower;
        }

        public string Brand
        {
            private get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    brand = "unknown";
                }
                else
                {
                    brand = value;
                }
            }
        }

        public string Model
        {
            private get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    model = "unknown";
                }
                else
                {
                    model = value;
                }
            }
        }

        public int HorsePower
        {
            private get { return horsePower; }
            set
            {
                if (value == 0)
                {
                    horsePower = -1;
                }
                else
                {
                    horsePower = value;
                }
            }
        }

        public override string ToString()
        {
            return $"The car is: {brand} {model} - {horsePower}HP.";
        }
    }
}
