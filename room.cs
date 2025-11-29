namespace room;
class Room
{
    room room1 = new Room(begginining, 0, 1, 1);
    room room2 = new Room(fork1, 1, 1, 1);
    room room3 = new Room(straight1, 1, 0, 1);
    room room4 = new Room(end1, 1, 0, 0);
    room room5 = new Room(straight2, 1, 0, 1);
    room room6 = new Room(fork2, 1, 1, 1);
    room room7 = new Room(straight3, 1, 0, 1);
    room room8 = new Room(end2, 0, 1, 0);
    room room9 = new Room(end3, 0, 0, 1);
    room room10 = new Room(finish, 0, 0, 1);
    public Room(string name, int up, int left, int right)
    {
        this.name = name;
        this.up = up;
        this.left = left;
        this.right = right;
    }    
    public void movement()
    {
        string direction = Console.ReadLine().ToUpper();

        switch (direction)
        {
            case "W":
            if (up == 1)
                {
                    Console.writeline("we are geniuses!");
                }
                else
                {
                    Console.writeline("Cannot go that direction");
                }
                break;
            case "A":
                break;
            case "D":
                break;
            default:
                Console.WriteLine("That is not an option");
                break;
        }
    }
}