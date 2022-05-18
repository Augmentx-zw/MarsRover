using MarsRover;

class Program
{

    static void Main()
    {
        var postionRoverA = new Postion
        {
            PosX = 1,
            PosY = 2,
            CardZ = "N"
        };
        string[] commandSetRoverA = { "L", "M", "L", "M", "L", "M", "L", "M", "M" };

        var postionRoverB = new Postion
        {
            PosX = 3,
            PosY = 3,
            CardZ = "E"
        };
        
        string[] commandSetRoverB = { "M", "M", "R", "M", "M", "R", "M", "R", "R", "M" };

        Rover roverA = new Rover(postionRoverA);
        Rover roverB = new Rover(postionRoverB);

        roverA.MoveToLocation(commandSetRoverA);
        roverB.MoveToLocation(commandSetRoverB);

        Console.WriteLine(roverA.x + " " + roverA.y + " " + roverA.card);
        Console.WriteLine(roverB.x + " " + roverB.y + " " + roverB.card);
        Console.ReadLine();
    }
}