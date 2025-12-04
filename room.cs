namespace room
{
    public class Room
    {
        public string name;
        public int up;
        public int left;
        public int right;

        public Room(string name, int up, int left, int right)
        {
            this.name = name;
            this.up = up;
            this.left = left;
            this.right = right;
        }
    }
}
