// dotnet add reference ../GameOfLife/GameOfLife.csproj
namespace GameOfLife.Tests
{
public class CellTest
    {
        [Fact]
        public void TestAdvanceCell()
        {
            // Arrange
            AutomatonSimulator automatonSimulator = new AutomatonSimulator();
            Cell cell = new Cell(100);
            cell.aliveNeighbours = 3;

            // Act
            cell.AdvanceCell();

            // Assert
            Assert.Equal(automatonSimulator.ShouldCellLive(3), cell.state);

            cell.aliveNeighbours = 1;

            // Act
            cell.AdvanceCell();

            // Assert
            Assert.Equal(automatonSimulator.ShouldCellLive(1), cell.state);
        }
        }
}