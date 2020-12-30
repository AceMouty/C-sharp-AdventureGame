
namespace AdvGame
{
    public class Player
    {
        private readonly string name;
        private Room currRoom;
        public Player(string name, Room room)
        {
            this.name = name;
            this.currRoom = room;
        }

        // accessors
        public string Name
        {
            get { return this.name; }
        }

        public Room CurrRoom
        {
            get { return this.currRoom; }
            set {this.currRoom = value; }
        }

        public string GetRoomDesc()
        {
            return this.CurrRoom.Description;
        }

        public void Travel(char direction)
        {
            var currentRoom = this.CurrRoom.GetRoomByDirection(direction);

            if(currentRoom != null)
            {
                this.CurrRoom = currentRoom;
                return;
            }
            System.Console.WriteLine("You can not move that way");
            return;
        }
    }
}