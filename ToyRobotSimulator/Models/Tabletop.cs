namespace ToyRobotSimulator.Models
{
    public class Tabletop
    {
        private const int Size = 5;
        public bool IsValidPosition(int x, int y) => x >= 0 && x < Size && y >= 0 && y < Size;
    }
}