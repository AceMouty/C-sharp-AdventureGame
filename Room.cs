
namespace AdvGame
{
    public class Room
    {
        private readonly string name;
        private readonly string description;
        private Room n_to;
        private Room s_to;
        private Room e_to;
        private Room w_to;

        public Room(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        // accessors
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
        }
        public Room N_To 
        {
            get
            {
                return this.n_to;
            } 
            set
            {
                this.n_to = value;
            } 
        }
        public Room S_To 
        {
            get
            {
                return this.s_to;
            }
            set
            {
                this.s_to = value;
            }
        }

        public Room E_To
        {
            get
            {
                return this.e_to;
            }
            set
            {
                this.e_to = value;
            }
        }

        public Room W_To
        {
            get
            {
                return this.w_to;
            }
            set
            {
                this.w_to = value;
            }
        }

        public Room GetRoomByDirection(char direction)
        {
            switch(direction)
            {
                case 'n':
                    return this.N_To;
                case 'e':
                   return this.E_To;
                case 's':
                    return this.S_To;
                case 'w':
                    return this.W_To;
                default:
                    return null;
            }
        }

    }
}