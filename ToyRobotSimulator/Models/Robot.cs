namespace ToyRobotSimulator.Models
{
    public class Robot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Direction { get; private set; }
        private readonly Tabletop _tabletop;
        private bool _isPlaced;

        public Robot(Tabletop tabletop)
        {
            _tabletop = tabletop;
            _isPlaced = false;
        }

        public void Place(int x, int y, string direction)
        {
            if (_tabletop.IsValidPosition(x, y))
            {
                X = x;
                Y = y;
                Direction = direction;
                _isPlaced = true;
                Console.WriteLine($"Robot placed at {X},{Y},{Direction}");
            }
            else
            {
                Console.WriteLine("Invalid position. Must be within 0-4 range.");
            }
        }

        public void Move()
        {
            if (!_isPlaced)
            {
                Console.WriteLine("Robot must be placed first.");
                return;
            }
            int newX = X, newY = Y;
            switch (Direction)
            {
                case "NORTH": newY++; break;
                case "SOUTH": newY--; break;
                case "EAST": newX++; break;
                case "WEST": newX--; break;
            }
            if (_tabletop.IsValidPosition(newX, newY))
            {
                X = newX;
                Y = newY;
                Console.WriteLine($"Robot moved to {X},{Y},{Direction}");
            }
            else
            {
                Console.WriteLine("Move ignored. Robot would fall off the table.");
            }
        }

        public void Left()
        {
            if (!_isPlaced) return;
            Direction = Direction switch
            {
                "NORTH" => "WEST",
                "WEST" => "SOUTH",
                "SOUTH" => "EAST",
                "EAST" => "NORTH",
                _ => Direction
            };
            Console.WriteLine($"Robot turned LEFT. Now facing {Direction}");
        }

        public void Right()
        {
            if (!_isPlaced) return;
            Direction = Direction switch
            {
                "NORTH" => "EAST",
                "EAST" => "SOUTH",
                "SOUTH" => "WEST",
                "WEST" => "NORTH",
                _ => Direction
            };
            Console.WriteLine($"Robot turned RIGHT. Now facing {Direction}");
        }

        public string Report()
        {
            string result = _isPlaced ? $"{X},{Y},{Direction}" : "Robot not placed on the table.";
            Console.WriteLine(result);
            return result;
        }
    }
}
