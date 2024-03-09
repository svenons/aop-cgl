namespace GameOfLife
{
    public interface ICell
    {
        bool state { get; set; }
        int aliveNeighbours { get; set; }
        public void CaclulateNeighbours();
        public void AdvanceCell();
    }
}