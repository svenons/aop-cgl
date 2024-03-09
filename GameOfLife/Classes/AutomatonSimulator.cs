namespace GameOfLife
{
    public class AutomatonSimulator {
        /*
        This class is meant to simulate the automaton.

        Any live cell with fewer than two live neighbors dies, as if by underpopulation.
        Any live cell with two or three live neighbors lives on to the next generation.
        Any live cell with more than three live neighbors dies, as if by overpopulation.
        Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

        A neighbor is considered any of the eight cells around the current cell, unless it's an edge case (e.g., for the top row, we will consider that there are no neighbors above it).

        */
        public bool ChanceCellStatus(int truePercentage) {
            Random random = new Random();
            return random.Next(0, 100) < truePercentage;
        }
        public bool ShouldCellLive(int aliveNeighbours) {
            switch (aliveNeighbours) {
                case 2:
                    return true;
                case 3:
                    return true;
                default:
                    return false;
            }
        }
    }
}