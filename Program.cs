using System.Dynamic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using player;
using room;

namespace Erik_B_Finn_B_text_based_maze_Final_project;

class Program
{

    public static void Main(string[] args)
    {
      //Player.input(); 
      //Room.Movement();
    }
    // class room for our second class.
public class Room
{
   
    public string name;
    public int up;
    public int right;
    public int left; 
    
public Room()
{
    //constructers for all the rooms 
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
        //constructer prefab
        this.name = name;
        this.up = up;
        this.left =left;
        this.right =right;
    }

    }
    // all of our rooms in ASCII
    static void Begginining()
    {
        Console.WriteLine("You arrive at the corn maze there is two paths to start which one do you take? You may go back if need be.");
        Console.WriteLine("  | A _______ D |");
        Console.WriteLine("  |_____    ____|");
        Console.WriteLine("        |  |     ");

    }
    static void Fork1()
    {
        Console.WriteLine("      Fork1");
        Console.WriteLine("|  W|_____________ ");
        Console.WriteLine("|______     _____D ");
        Console.WriteLine("       |    |      ");
        Console.WriteLine("       |    |______");
        Console.WriteLine("         A         ");
    }
    static void Straight1()
    {
    Console.WriteLine("Straight1");
    Console.WriteLine(" ______| W  |");
    Console.WriteLine("|_______    |");
    Console.WriteLine("          D  ");
    }
    static void End1()
    {
    Console.WriteLine("End1");
    Console.WriteLine(" ____        ");
    Console.WriteLine("|    |_____  ");
    Console.WriteLine("   W         ");
    }
    static void Straight2()
    {
    Console.WriteLine("Straight2");
    Console.WriteLine("              W  ");
    Console.WriteLine("  __________|   |");
    Console.WriteLine(" D _____________|");
    }
    static void Fork2()
    {
    Console.WriteLine("Fork2");
    Console.WriteLine("       ____| A|_____ ");
    Console.WriteLine("      |    _________D");
    Console.WriteLine("______| W  |         ");
    }
    static void Straight3()
    {
    Console.WriteLine("Straight3");
    Console.WriteLine("            | D |");
    Console.WriteLine("  __________|   |");
    Console.WriteLine("              W  ");
    }
    static void End2()
    {
    Console.WriteLine("End2");
    Console.WriteLine("      ____    ");
    Console.WriteLine("     |    |   ");
    Console.WriteLine(" ____|  A |___");
    }
    static void End3()
    {
    Console.WriteLine("End3");
    Console.WriteLine(" ___________ ");
    Console.WriteLine(" D__________|");
    }
    static void Finish()
    {
    Console.WriteLine("Finish");
    Console.WriteLine("|____________      ______________|");
    Console.WriteLine("             |  D |               ");
    Console.WriteLine("");
    }
}

