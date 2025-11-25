namespace player;
public class Player
{
    public string name;
    public string location;

    public static void input()
    {
       ConsoleKeyInfo inputs =Console.ReadKey();

        switch (inputs.Key) 

        { 

            case ConsoleKey.W: 

                bool w = true; 

                if (w == true) 

                { 

                    w = false; 

                    Console.WriteLine("forward"); 

                    Player.input(); 

                } 

                break; 

 

            case ConsoleKey.A: 

                bool a = true; 

                if (a == true) 

                { 

                    a = false; 

                    Console.WriteLine("left"); 

                    Player.input(); 

                } 

 

                break; 

            case ConsoleKey.D: 

                bool d = true; 

                if (d == true) 

                { 

                    d = false; 

                    Console.WriteLine("right"); 

                    Player.input(); 

                } 

 

                break; 

            default: 

                Console.WriteLine("That is not a valid option. Try again."); 

                Player.input(); 

                break; 
        }
    }
}