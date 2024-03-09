using System.Runtime.CompilerServices;

namespace GameOfLife
{
    public interface IGrid
    {
        int rows { get; set; }
        int columns { get; set; }
        List<List<ICell>> grid { get; set; }
        public int getRow(ICell cell);
        public int getColumn(ICell cell);
        public void InitializeGrid(int rows, int columns);
        public bool GetCellStatus(int row, int col);
        public void AdvanceGrid();
    }
}