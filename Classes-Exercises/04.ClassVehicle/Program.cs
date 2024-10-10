namespace _04.ClassVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMyVehicle = Console.ReadLine();
            string model = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());
            int enginePower = int.Parse(Console.ReadLine());

            Engine engine = new Engine();
            engine.Power = enginePower;

            Vehicle vehicle = new Vehicle(typeOfMyVehicle, model, engine, fuel);
            
            Console.WriteLine(vehicle.Drive(100));
        }
    }
}
