class TestClass 
{
    public static void Main()
    {
        int a = 1;
        int b = 2;

        Console.WriteLine(a + b);
    }
    
    //add method to take 2 numbers and multiply them with each other
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    //add method to take 2 numbers and add them with each other
    public static int Add(int a, int b)
    {
        return a + b;
    }

    //add method to take 2 numbers and subtract them with each other
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    //add method to take 2 numbers and divide them with each other
    public static int Divide(int a, int b)
    {
        return a / b;
    }

    public string GiveHexColorByName(string name)
    {
        switch (name)
        {
            case "red":
                return "0xFF0000";
            case "green":
                return "0x00FF00";
            case "blue":
                return "0x0000FF";
            case "purple":
                return "0xFF00FF";
            case "yellow":
                return "0xFFFF00";
            case "orange":
                return "0xFFA500";
            case "black":
                return "0x000000";
            case "white":
                return "0xFFFFFF";
            default:
                return "0x000000";
        }
    }

    public string GiveHexColorByNumber(int number)
    {
        switch (number)
        {
            case 1:
                return "0xFF0000";
            case 2:
                return "0x00FF00";
            case 3:
                return "0x0000FF";
            case 4:
                return "0xFF00FF";
            case 5:
                return "0xFFFF00";
            case 6:
                return "0xFFA500";
            case 7:
                return "0x000000";
            case 8:
                return "0xFFFFFF";
            default:
                return "0x000000";
        }
    }

    // Create method to start chess Game from console
    public void StartChessGame()
    {
        ChessGame chessGame = new ChessGame();
        chessGame.StartGame();
    }
    
    // create a class called ChessGame with a method called StartGame
    class ChessGame
    {
        public void StartGame()
        {
            Console.WriteLine("Welcome to Chess!");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Game started!");
            Console.WriteLine("Press any key to exit...");
        }
    }
}