
namespace AdvGame
{
    public class Player
    {
        private readonly string Name;
        private Room CurrRoom;
        public Player(string name, Room room)
        {
            this.Name = name;
            this.CurrRoom = room;
        }

        // getters and setters
        // TODO: Implament C# getters and setters

        public string GetCurrRoom()
        {
            return this.CurrRoom.GetDesc();
        }

        public void SetCurrRoom(Room newRoom)
        {
            this.CurrRoom = newRoom;
        }

        public string GetPlayerName()
        {
            return this.Name;
        }

        public void Travel(char direction)
        {
            var currentRoom = this.CurrRoom.GetRoomDirection(direction);

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