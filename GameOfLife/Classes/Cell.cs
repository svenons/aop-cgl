namespace GameOfLife
{
    public class Cell: ICell
    {
        AutomatonSimulator automatonSimulator = new AutomatonSimulator();
        public Cell(int truePercentage)
        {
            this.state = automatonSimulator.ChanceCellStatus(truePercentage);
        }
        public bool state { get; set; }
        public int aliveNeighbours { get; set; }
        public void CalculateNeighbours(IGrid grid)
        {
            int row = grid.getRow(this);
            int col = grid.getColumn(this);

            int aliveNeighbours = 0;
            // Check the eight neighboring cells
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    // Skip the current cell
                    if (i == row && j == col)
                        continue;
                    // Check if the neighboring cell is within the grid boundaries
                    if (i >= 0 && i < grid.rows && j >= 0 && j < grid.columns)
                    {
                        bool neighbor = grid.GetCellStatus(i, j);
                        if (neighbor)
                        {
                            aliveNeighbours++;
                        }
                    }
                }
            }

            this.aliveNeighbours = aliveNeighbours;
        }
        public void AdvanceCell()
        {
            this.state = automatonSimulator.ShouldCellLive(this.aliveNeighbours);
        }
    }
}