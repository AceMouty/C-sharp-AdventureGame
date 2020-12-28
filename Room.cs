
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

        // getters and setters (nieve setup)
        // TODO: implament the C# way of generating getters and setters

        public Room GetN_To() 
        {
            if (n_to != null){
                return n_to;
            }
            
            return null;
        }

        public void SetN_To(Room room){
            this.n_to = room;
        }

        public Room GetS_To()
        {
            if(s_to != null)
            {
                return this.s_to;
            } 

            return null;
        }

        public void SetS_To(Room room)
        {
            this.s_to = room;
        }

        public Room GetE_To()
        {
            if(e_to != null)
            {
                return this.e_to;
            }

            return null;
        }

        public void SetE_To(Room room)
        {
            this.e_to = room;
        }

        public Room GetW_To()
        {
            if(w_to != null)
            {
                return this.w_to;
            }

            return null;
        }

        public void SetW_To(Room room)
        {
            this.w_to = room;
        }

        public string GetDesc()
        {
            return this.description;
        }
    }
}