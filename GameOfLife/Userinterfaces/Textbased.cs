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
    }
}