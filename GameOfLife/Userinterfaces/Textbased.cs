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
                    StartNewGame();
                    break;
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
        public void StartNewGame()
        {
            // Start new grid
            int rows = 0;
            do {
                Console.Clear();
                Console.WriteLine("Enter the number of rows for the grid (4-100)");
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
                Console.WriteLine("Enter the number of columns for the grid (4-100)");
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

                Console.WriteLine("Press 'N' to advance to the next generation.");
                Console.WriteLine("Press 'S' to save the current grid state to a file.");
                Console.WriteLine("Press 'X' to exit the simulation.");
                var key = Console.ReadKey();

                do {
                    switch (key.Key)
                    {
                        case ConsoleKey.N:
                            grid.AdvanceGrid();
                            break;
                        case ConsoleKey.S:
                            Console.WriteLine("Enter the file name to save the grid to:");
                            Console.Write(">> ");
                            string fileName = Console.ReadLine()!;
                            // Save grid to file
                            //JsonStorage storage = new JsonStorage();
                            //storage.SaveGrid(grid, fileName);
                            break;
                        case ConsoleKey.X:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            key = Console.ReadKey();
                            break;
                    }
                } while (key.Key != ConsoleKey.N && key.Key != ConsoleKey.S && key.Key != ConsoleKey.X);
            }
        }
    }
}