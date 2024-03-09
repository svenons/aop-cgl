namespace GameOfLife.Tests
{
    public class GridTest
    {
        [Fact]
        public void InitializeGrid_ShouldCreateGridWithCorrectSize()
        {
            // Arrange
            int rows = 3;
            int columns = 4;
            Grid grid = new Grid() { grid = new List<List<ICell>>() };

            // Act
            grid.InitializeGrid(rows, columns);

            // Assert
            Assert.Equal(rows, grid.rows);
            Assert.Equal(columns, grid.columns);
        }

        [Fact]
        public void GetCellStatus_ShouldReturnCorrectStatus()
        {
            // Arrange
            Grid grid = new Grid() { grid = new List<List<ICell>>() };
            grid.InitializeGrid(3, 3);
            grid.grid[1][1].state = true;

            // Act
            bool cellStatus = grid.GetCellStatus(1, 1);

            // Assert
            Assert.True(cellStatus);
        }

        [Fact]
        public void AdvanceGrid_ShouldAdvanceAllCells()
        {
            // Arrange
            Grid grid = new Grid() { grid = new List<List<ICell>>() };
            grid.InitializeGrid(4, 4, 100); // 100%, so all cells in grid are alive - all should be dead, because many many neighbours for each cell.

            // Act
            
            grid.AdvanceGrid();

            // Assert
            Assert.False(grid.grid[1][1].state);
        }

        [Fact]
        public void GetGridStatus_ShouldReturnCorrectStatus()
        {
            // Arrange
            Grid grid = new Grid() { grid = new List<List<ICell>>() };
            grid.InitializeGrid(3, 3);
            grid.grid[1][1].state = true;

            // Act
            List<List<bool>> gridStatus = grid.GetGridStatus();

            // Assert
            Assert.True(gridStatus[1][1]);
        }
    }
}
