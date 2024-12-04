namespace HotelRoomReservationSystem
{
    internal class Room
    {
        private int roomNumber;
        private string type;
        private decimal pricePerNight;
        private decimal cancellationFee;
        private string status;

        public Room(int roomNumber, string type, decimal pricePerNight, decimal cancellationFee, string status)
        {
            RoomNumber = roomNumber;
            Type = type;
            PricePerNight = pricePerNight;
            CancellationFee = cancellationFee;
            Status = status;
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            private set { roomNumber = value; }
        }

        public string Type { get; private set; }

        public decimal PricePerNight { get; private set; }

        public decimal CancellationFee { get; private set; }

        public string Status { get; private set; }

        public void ChangeStatus(string status)
        {
            Status = status;
        }

        public override string ToString()
        {
            return $"Room Number: {this.roomNumber}, room type: {this.type}, status: {this.status}, price per night: {this.pricePerNight}";
        }
    }
}
