namespace GameOfLife
{
    public interface IStorage
    {
        public void SaveGrid(IGrid grid, string path);
        public IGrid LoadGrid(string path);
    }
}