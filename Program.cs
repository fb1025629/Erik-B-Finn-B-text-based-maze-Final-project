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
        start();
        Player.input();
        Room.normal();


    }
    static void start(){
        Console.WriteLine("You arrive at the corn maze there is two paths to start which one do you take? You may go back if need be.");
        Console.WriteLine("  | A _______ D |");
        Console.WriteLine("  |_____    ____|");
        Console.WriteLine("        |  |     ");

    }
    static void backpack()//this will tell the player what items they have 
    {

    }
    static void location()//will retell the player where they are at and describe the area around them
    {
        
        
        
    }

}
