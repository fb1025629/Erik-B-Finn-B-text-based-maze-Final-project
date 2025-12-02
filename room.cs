
using System.Security.Cryptography.X509Certificates;

namespace room;
public class Room
{
    
    public string name;
    public int up;
    public int right;
    public int left; 
    
public Room()
{
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
}
    
    public Room(string name, int up, int left, int right)
    {
        this.name = name;
        this.up = up;
        this.left =left;
        this.right =right;
    }
    public void Movement(int up, int left, int right, string name)
    {
        string direction = Console.ReadLine().ToUpper();

        switch (direction)
        {
            case "W":
            if (up == 1)
                {
                    Console.WriteLine("we are geniuses!");
                }
                else
                {
                    Console.WriteLine("Cannot go that direction");
                }
                break;
            case "A":
            if (left == 1)
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("Cannot go that direction");
                }
                break;
            case "D":
            if (right == 1)
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