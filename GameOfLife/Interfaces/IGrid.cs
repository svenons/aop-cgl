using System.Runtime.CompilerServices;

namespace GameOfLife
{
    public interface IGrid
    {
        int rows { get; set; }
        int columns { get; set; }
        List<List<ICell>> grid { get; set; }
        public void InitializeGrid(int rows, int columns);
        public List<List<Boolean>> GetCellSattus();
        public void AdvanceGrid();
    }
}