namespace _01.CarInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                List<string> carInformation = Console.ReadLine().Split().ToList();

                Car car = new Car();
                car.Brand = carInformation[0];
                car.Model = carInformation[1];
                car.HorsePower = int.Parse(carInformation[2]);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
