using System;

string room = "mancave";

while (room != "exit")
{
    if(room == "mancave"){
        Console.WriteLine("you are in your mancave");
        string action = Console.ReadLine();
        if(action == "classroom"){
            room = "classroom";
        } else if (action == "lab") {
            Console.WriteLine("you are in the lab. go home? exit / stay");
            action = Console.ReadLine();
            if (action == "exit"){
                room = "mancave";
            } else {action = "lab";}
        }
    } else if (room == "classroom"){
        while(room != "lab" || room != "mancave"){
            Console.WriteLine("you are in the classroom");
            action = Console.WriteLine();
        }
    }
}