namespace room;
class Room
{
    
    string Name;
    int Up ;
    int Right;
    int Left; 


    Room room1 = new Room("Begginining", 0, 1, 1);
    Room room2 = new Room("Fork1", 1, 1, 1);
    Room room3 = new Room("Straight1", 1, 0, 1);
    Room room4 = new Room("End1", 1, 0, 0);
    Room room5 = new Room("Straight2", 1, 0, 1);
    Room room6 = new Room("Fork2", 1, 1, 1);
    Room room7 = new Room("Straight3", 1, 0, 1);
    Room room8 = new Room("End2", 0, 1, 0);
    Room room9 = new Room("End3", 0, 0, 1);
    Room room10 = new Room("Finish", 0, 0, 1);
    public Room(string name, int up, int left, int right)
    {
        this.Name = name;
        this.Up = up;
        this.Left = left;
        this.Right = right;
    }    
    public void Movement()
    {
       
        string direction = Console.ReadLine().ToUpper();

        switch (direction)
        {
            case "W":
            if (Up == 1)
                {
                    Console.WriteLine("we are geniuses!");
                }
                else
                {
                    Console.WriteLine("Cannot go that direction");
                }
                break;
            case "A":
            if (Left == 1)
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("Cannot go that direction");
                }
                break;
            case "D":
            if (Right == 1)
                {
                    Console.WriteLine("it worked");
                }
                else
                {
                    Console.WriteLine("Cannot go that direction");
                }
                break;
            default:
                Console.WriteLine("That is not an option");
                break;
            
        }
    }
}