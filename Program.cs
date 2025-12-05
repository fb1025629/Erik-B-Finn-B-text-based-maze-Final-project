using System;
using System.Collections.Generic;
using System.IO;

namespace Game
{
    //this is the main program
    public class Program
    {
        public static void Main()
        {
            Game game = new Game();

            Console.Write("Enter your name: ");
            Player player = new Player(Console.ReadLine());

            while (true)
            {
                game.ROOM(player);

                Console.WriteLine("Controlls are W A D and Q to quit");
                ConsoleKey input = Console.ReadKey(true).Key;


                if (input == ConsoleKey.Q) 
                {
                    break;
                }

                game.Move(player, input);
            }
        }
    }
   //this is the player say hi player
    public class Player
    {
        public string Name;
        public int Checkroom;

        public Player(string name)
        {
            Name = name;
            Checkroom = 0; // Start at room 0
        }
    }
    public class Room
    {
        public string Name;
        public int Up;
        public int Left;
        public int Right;

        public Room(string name, int up, int left, int right)
        {
            Name = name;
            Up = up;
            Left = left;
            Right = right;
        }
    }
    public static class rooms
    {
        public static void Beginginging()
        {
            Console.WriteLine("You arrive at the corn maze...");
            Console.WriteLine("  | A _______ D |");
            Console.WriteLine("  |_____    ____|");
            Console.WriteLine("        |  |     ");
        }

        public static void Fork1()
        {
            Console.WriteLine("      Fork1");
            Console.WriteLine("|  W|_____________ ");
            Console.WriteLine("|______      _____D ");
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

        public static void End1()
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
            Console.WriteLine("  __________|   |");
            Console.WriteLine(" D _____________|");
        }

        public static void Fork2()
        {
            Console.WriteLine("Fork2");
            Console.WriteLine("       ____| A|_____ ");
            Console.WriteLine("      |    _________D");
            Console.WriteLine("______| W  |         ");
        }

        public static void Straight3()
        {
            Console.WriteLine("Straight3");
            Console.WriteLine("            | D |");
            Console.WriteLine("  __________|   |");
            Console.WriteLine("              W  ");
        }

        public static void End2()
        {
            Console.WriteLine("End2");
            Console.WriteLine("      ____    ");
            Console.WriteLine("     |    |   ");
            Console.WriteLine(" ____|  A |___");
        }

        public static void End3()
        {
            Console.WriteLine("End3");
            Console.WriteLine(" ___________ ");
            Console.WriteLine(" D__________|");
        }

        public static void Finish()
        {
            Console.WriteLine("Finish!");
            Console.WriteLine("|____________      ______________|");
            Console.WriteLine("             |  D |               ");
        }

        // Selects the room based on what the room name is
        public static void ROOMS(Room room)
        {
             if (room.Name == "Beginning")
    {
        Beginginging();
    }
    else if (room.Name == "Fork1")
    {
        Fork1();
    }
    else if (room.Name == "Straight1")
    {
        Straight1();
    }
    else if (room.Name == "End1")
    {
        End1();
    }
    else if (room.Name == "Straight2")
    {
        Straight2();
    }
    else if (room.Name == "Fork2")
    {
        Fork2();
    }
    else if (room.Name == "Straight3")
    {
        Straight3();
    }
    else if (room.Name == "End2")
    {
        End2();
    }
    else if (room.Name == "End3")
    {
        End3();
    }
    else if (room.Name == "Finish")
    {
        Finish();
    }
        }
    }
    public class Game
    {
        public List<Room> Rooms = new List<Room>();
        public Game()
        {
            LoadRooms();
        }
        public void LoadRooms()
        {
            Rooms.Add(new Room("Beginginging", 1, 0, 1)); 
            Rooms.Add(new Room("Fork1",     1, 1, 1));
            Rooms.Add(new Room("Straight1", 1, 0, 1));
            Rooms.Add(new Room("End1",      0, 1, 0)); 
            Rooms.Add(new Room("Straight2", 1, 0, 1)); 
            Rooms.Add(new Room("Fork2",     1, 1, 1)); 
            Rooms.Add(new Room("Straight3", 1, 0, 1)); 
            Rooms.Add(new Room("End2",      0, 1, 0)); 
            Rooms.Add(new Room("End3",      0, 0, 1));  
            Rooms.Add(new Room("Finish",    0, 0, 0)); 
        }
        public void ROOM(Player a)
        {
            Console.Clear();

            Room current = Rooms[a.Checkroom];

            Console.WriteLine($"You are in: {current.Name}");
            Console.WriteLine("-----------------------------------");

        rooms.ROOMS(current);

        }
        public void Move(Player player, ConsoleKey input)
        {
            Room c = Rooms[player.Checkroom];

            switch (input)
            {
                case ConsoleKey.W:
                    if (c.Up == 1)
                        player.Checkroom++;
                    else
                        Console.WriteLine("You cannot go forward!");
                    break;

                case ConsoleKey.A:
                    if (c.Left == 1)
                        player.Checkroom--;
                    else
                        Console.WriteLine("You cannot go left!");
                    break;

                case ConsoleKey.D:
                    if (c.Right == 1)
                        player.Checkroom++;
                    else
                        Console.WriteLine("You cannot go right!");
                    break;
            }
        }
    }

    //main program
}
