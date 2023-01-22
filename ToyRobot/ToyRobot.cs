using System;

namespace ToyRobot
{
    public class ToyRobot
    {
        public int row;
        public int col;
        
        Direction direction;
        bool isPlaced;
        const string invalidCmdError = "Invalid command, robot must be placed first properly.";

        public void Place(int newRow, int newCol, Direction newDirection)
        {
            if (newRow >= 0 && newRow <= 4 && newCol >= 0 && newCol <= 4)
            {
                row = newRow;
                col = newCol;
                direction = newDirection;
                isPlaced = true;
            }
            else
            {
                Console.WriteLine("Invalid placement.");
            }
        }

        public void Move()
        {
            if (!isPlaced)
            {
                Console.WriteLine(invalidCmdError);
                return;
            }

            if (direction == Direction.NORTH)
                col++;
            else if (direction == Direction.EAST)
                row++;
            else if (direction == Direction.SOUTH)
                col--;
            else if (direction == Direction.WEST)
                row--;

            if (row < 0 || row > 4 || col < 0 || col > 4)
            {
                row = Math.Max(0, row);
                row = Math.Min(4, row);
                col = Math.Max(0, col);
                col = Math.Min(4, col);
              
                Console.WriteLine("Cannot move outside of table.");
            }
        }

        public void Left()
        {
            if (!isPlaced)
            {
                Console.WriteLine(invalidCmdError);
                return;
            }

            if (direction == Direction.NORTH)
                direction = Direction.WEST;
            else if (direction == Direction.EAST)
                direction = Direction.NORTH;
            else if (direction == Direction.SOUTH)
                direction = Direction.EAST;
            else if (direction == Direction.WEST)
                direction = Direction.SOUTH;
        }

        public void Right()
        {
            if (!isPlaced)
            {
                Console.WriteLine(invalidCmdError);
                return;
            }

            if (direction == Direction.NORTH)
                direction = Direction.EAST;
            else if (direction == Direction.EAST)
                direction = Direction.SOUTH;
            else if (direction == Direction.SOUTH)
                direction = Direction.WEST;
            else if (direction == Direction.WEST)
                direction = Direction.NORTH;
        }

        public void Report()
        {
            if (!isPlaced)
            {
                Console.WriteLine(invalidCmdError);
                return;
            }

            Console.WriteLine($"Row:{row}, Column:{col}, Direction:{direction}");
        }
    }
}
