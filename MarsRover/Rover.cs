namespace MarsRover
{
    public class Rover
    {
        public int x = 0;
        public int y = 0;
        public string? card;

        public Rover(Postion pos)
        {
            x = pos.PosX;
            y = pos.PosY;
            card = pos.CardZ;
        }

        public void SpinLeft()
        {
            // get current cardnal point spin left to the face the other cardnal point
            switch (card)
            {
                case "N":
                    card = "W";
                    break;
                case "W":
                    card = "S";
                    break;
                case "S":
                    card = "E";
                    break;
                case "E":
                    card = "N";
                    break;
                default:
                    throw new Exception("Invalid direction");
            }
        }

        public void SpinRight()
        {
            switch (card)
            {
                case "N":
                    card = "E";
                    break;
                case "E":
                    card = "S";
                    break;
                case "S":
                    card = "W";
                    break;
                case "W":
                    card = "N";
                    break;
                default:
                    throw new Exception("Invalid direction");
            }
        }

        public void MoveForward()
        {
            //move postion x or y by 1 facing the same cardnil direction
            // get the cardinal direction and determine x and y and move accordingly one step 
            switch (card)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    //NB: we decrease as we are going negative on the cartesian plane
                    y -= 1; 
                    break;
                case "W":
                    //NB: we decrease as we are going negative on the cartesian plane
                    x -= 1;
                    break;
                default:
                    throw new Exception("Invalid step");
            }
        }

        public void MoveToLocation(string[] commands)
        {
            // follow the command set to move the rover
            foreach (var command in commands)
            {
                switch (command)
                {
                    case "L":
                        SpinLeft();
                        break;
                    case "R":
                       SpinRight();
                        break;
                    case "M":
                        MoveForward();
                        break;
                    default:
                        throw new Exception("Invalid command");
                }
            }
        }

    }
}
