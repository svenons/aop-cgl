namespace GameOfLife
{
    public class Grid: IGrid
    {
        public int rows { get; set; }
        public int columns { get; set; }
        public required List<List<ICell>> grid { get; set; }
        public void InitializeGrid(int rows, int columns)
        {
            throw new System.NotImplementedException();
        }
        public List<List<Boolean>> GetCellSattus()
        {
            throw new System.NotImplementedException();
        }
        public void AdvanceGrid()
        {
            throw new System.NotImplementedException();
        }
    }
}