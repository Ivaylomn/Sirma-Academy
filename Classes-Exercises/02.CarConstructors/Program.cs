namespace _02.CarConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carsInformation = Console.ReadLine().Split().ToArray();
                string brand = carsInformation[0];
                
                if (carsInformation.Length > 1)
                {
                    string model = carsInformation[1];
                    if (carsInformation.Length > 2)
                    {
                        int horsePower = int.Parse(carsInformation[2]);
                        Car car = new Car(brand, model, horsePower);
                        cars.Add(car);
                    }
                    else
                    {
                        Car car = new Car(brand, model, 0);
                        cars.Add(car);
                    }
                }
                else
                {
                    Car car = new Car(brand);
                    cars.Add(car);
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
