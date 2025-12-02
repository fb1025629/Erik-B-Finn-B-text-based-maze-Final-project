
using System.Security.Cryptography.X509Certificates;

namespace room;
public class Room
{
     string direction = Console.ReadLine().ToUpper();
    public string name;
    public int up;
    public int right;
    public int left; 
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