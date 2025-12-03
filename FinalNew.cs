using System.Data;


Console.WriteLine("You arrive at the corn maze there is two paths to start which one do you take? You may go back if need be.");
        Console.WriteLine("  | A _______ D |");
        Console.WriteLine("  |_____    ____|");
        Console.WriteLine("        |  |     ");

string direction = Console.ReadLine().ToUpper();
if (direction == "Left")
{
    Console.WriteLine("|  W|_____________ ");
    Console.WriteLine("|______      _____D ");
    Console.WriteLine("       |    |      ");
    Console.WriteLine("       |    |______");
    Console.WriteLine("         A         ");
    Console.WriteLine("This is where you are now you can go up, right, or go back.");
    direction = Console.ReadLine().ToUpper();
    if (direction == "Up")
    {
        Console.WriteLine(" ____        ");
        Console.WriteLine("|    |_____  ");
        Console.WriteLine("   W         ");
    }
    if (direction == "Right")
    {
        Console.WriteLine("              W  ");
        Console.WriteLine("  __________|   |");
        Console.WriteLine(" D _____________|");
    }
    if  (direction == "Back")
    {
        
    }
}
else
{
    
    Console.WriteLine(" ______| W  |");
    Console.WriteLine("|_______    |");
    Console.WriteLine("          D  ");
}