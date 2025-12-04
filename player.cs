namespace MazeGame;

public class Player
{
    public string Name;
    public int CurrentRoom;

    public Player(string name)
    {
        Name = name;
        CurrentRoom = 0;  // start at room 0
    }
}