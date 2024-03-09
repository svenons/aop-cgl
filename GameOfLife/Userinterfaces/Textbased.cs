namespace GameOfLife
{
    public class Textbased
    {
        public Textbased()
        {
            MainMenu();
        }
        public void MainMenu(bool clear = true)
        {
            if (clear) {Console.Clear();}
            Console.WriteLine("Welcome to the Game of Life!");
            Console.WriteLine("1. Start a new game");
            Console.WriteLine("2. Load a game");
            Console.WriteLine("3. Exit");
            Console.WriteLine("\nPlease enter your choice: ");
            Console.Write(">> ");
            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    // Start new grid
                    int rows = 0;
                    do {
                        Console.Clear();
                        Console.WriteLine("Enter the number of rows: ");
                        Console.Write(">> ");
                        string userInput = Console.ReadLine()!;
                        if (!string.IsNullOrWhiteSpace(userInput) && int.TryParse(userInput, out rows) && rows > 3 && rows <= 100)
                        {
                            break;
                        }
                    } while(true);

                    int columns = 0;
                    do {
                        Console.Clear();
                        Console.WriteLine("Enter the number of columns: ");
                        Console.Write(">> ");
                        string userInput = Console.ReadLine()!;
                        if (!string.IsNullOrWhiteSpace(userInput) && int.TryParse(userInput, out columns) && columns > 3 && columns <= 100)
                        {
                            break;
                        }
                    } while(true);

                    Grid grid = new Grid() { grid = new List<List<ICell>>() };
                    grid.InitializeGrid(rows, columns);
                    
                    while(true)
                    {
                        List<List<bool>> status = grid.GetGridStatus();
                        Console.WriteLine("Initial grid status:");
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                if (status[i][j])
                                {
                                    Console.Write("O");
                                }
                                else
                                {
                                    Console.Write(".");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Press any key to advance the grid...");
                        Console.ReadKey();
                        grid.AdvanceGrid();
                    }
                    //break;
                case "2":
                    // Load existing grid from a file
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    MainMenu(false);
                    break;
            }
        }
    }
}