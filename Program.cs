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
      Player.input();

    }
    public static void Begginining()
    {
        Console.WriteLine("You arrive at the corn maze there is two paths to start which one do you take? You may go back if need be.");
        Console.WriteLine("  | A _______ D |");
        Console.WriteLine("  |_____    ____|");
        Console.WriteLine("        |  |     ");

    }
    public static void Fork1()
    {
        Console.WriteLine("      Fork1");
        Console.WriteLine("|  W|_____________ ");
        Console.WriteLine("|______     _____D ");
        Console.WriteLine("       |    |      ");
        Console.WriteLine("       |    |______");
        Console.WriteLine("         A         ");
    }
    public static void Straight1()
    {
    Console.WriteLine("Straight1");
    Console.WriteLine(" ______| W  |");
    Console.WriteLine("|_______    |");
    Console.WriteLine("          D  ");
    }
    public static void End()
    {
    Console.WriteLine("End1");
    Console.WriteLine(" ____        ");
    Console.WriteLine("|    |_____  ");
    Console.WriteLine("   W         ");
    }
    public static void Straight2()
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
