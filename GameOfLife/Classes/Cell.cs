namespace GameOfLife
{
    public class Cell: ICell
    {
        public bool state { get; set; }
        public int aliveNeighbours { get; set; }
        public void CaclulateNeighbours()
        {
            throw new System.NotImplementedException();
        }
        public void AdvanceCell()
        {
            throw new System.NotImplementedException();
        }
    }
}