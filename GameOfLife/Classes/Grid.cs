using System.Data;

namespace GameOfLife
{
    public class Grid: IGrid
    {
        public int rows { get; set; }
        public int columns { get; set; }
        public required List<List<ICell>> grid { get; set; }
        public int getRow(ICell cell)
        {
            return grid.FindIndex(row => row.Contains(cell));
        }
        public int getColumn(ICell cell)
        {
            return grid[getRow(cell)].IndexOf(cell);
        }
        public void InitializeGrid(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            for (int i = 0; i < rows; i++)
            {
                List<ICell> row = new List<ICell>();
                for (int j = 0; j < columns; j++)
                {
                    row.Add(new Cell());
                }
                grid.Add(row);
            }
        }
        public bool GetCellStatus(int row, int col)
        {
            return grid[row][col].state;
        }
        public void AdvanceGrid()
        {
            foreach (List<ICell> row in grid)
            {
                foreach (ICell cell in row)
                {
                    cell.CalculateNeighbours(this);
                    cell.AdvanceCell();
                }
            }
        }
        public List<List<bool>> GetGridStatus()
        {
            List<List<bool>> status = new List<List<bool>>();
            foreach (List<ICell> row in grid)
            {
                List<bool> rowStatus = new List<bool>();
                foreach (ICell cell in row)
                {
                    rowStatus.Add(cell.state);
                }
                status.Add(rowStatus);
            }
            return status;
        }
    }
}