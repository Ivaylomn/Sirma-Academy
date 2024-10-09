namespace _01.CarInfo
{
    internal class Car
    {
        private string brand;
        private string model;
        private int horsePower;

        public string Brand { get ; set; }
        public string Model { get => model; set => model = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }

        public string CarInfo() 
        {
            return $"The car is: {brand} {model} - {horsePower}HP.";
        }
        //Here I override ToString. I think that is right way, but in task write to use CarInfo method
        public override string ToString()
        {
            return $"The car is: {brand} {model} - {horsePower}HP.";
        }
    }
}
