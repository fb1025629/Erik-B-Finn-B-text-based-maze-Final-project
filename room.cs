namespace room;
public class Room
{
    public static void dooroom1()
    {
        
    }

    public static void keyroom1()
    {
        
    }
    public static void normal()
    {
        // This is an array that is used for checking the map and traversing it. 

        string x = "beginining"; 

        string checkLocation = ""; 

        string[] norm_room = { "beginining", "fork1", "straight1", "end1", "straight2", "fork2", "straight3", "end2", "end3", "finish"  }; 

        if (x == norm_room[0]) 

        { 

            checkLocation = "beginining"; 

        } 

        else if (x == norm_room[1]) 

        { 

            checkLocation = "fork1"; 

        } 

        else if (x == norm_room[2]) 

        { 

            checkLocation = "straight1"; 
            bool key1 = true;
            if (key1 == true && x == end1)
            {
                dooroom1 = 
            }

        } 

        else if (x == norm_room[3]) 

        { 

            checkLocation = "end1"; 

        } 

        else if (x == norm_room[4]) 

        { 

            checkLocation = "straight2"; 

        } 

        else if (x == norm_room[5]) 

        { 

            checkLocation = "fork2"; 

        } 

        else if (x == norm_room[6]) 

        { 

            checkLocation = "straight3"; 

        } 

        else if (x == norm_room[7]) 

        { 

            checkLocation = "end2"; 

        } 

        else if (x == norm_room[8]) 

        { 

            checkLocation = "end3"; 

        } 

        else if (x == norm_room [9]) 

        { 

            checkLocation = "finish"; 

        } 
    }
    public static void endroom()
    {
        
    }
}