public static class RandomProvider
{
    private static int seed = Environment.TickCount;

    private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
        new Random(Interlocked.Increment(ref seed))
    );

    public static Random GetThreadRandom()
    {
        return randomWrapper.Value;
    }
}

public static class RandomString 
{
    public static string Get(int length)
    {
        string randString = String.Empty;

        for (var i = 0; i < length; i++)
            randString += ((Char)RandomProvider.GetThreadRandom().Next(32, 126)).ToString();

        return randString;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int symbols = 1; // number of pick symbols
        string login = ""; // Authentication login (Enter any value until the function is completed)
        string password = ""; // Password to be chosen
        int cycle = 0; // the number of cycles
        int increase = 0; // degree magnifier
        int function = 1; // number of increase degree
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter login ");
        login = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Password ");
        password = Convert.ToString(Console.ReadLine());
        while (cycle == 0)
        {
            increase++;
            symbols = function;
            if (cycle == 0)
            {
                string vs  = RandomString.Get(symbols);
                string vs1 = RandomString.Get(symbols);
                string vs2 = RandomString.Get(symbols);
                string vs3 = RandomString.Get(symbols);
                string vs4 = RandomString.Get(symbols);
                string vs5 = RandomString.Get(symbols);
                string vs6 = RandomString.Get(symbols);
                string vs7 = RandomString.Get(symbols);
                string vs8 = RandomString.Get(symbols);
                string vs9 = RandomString.Get(symbols);
                string vs10 = RandomString.Get(symbols);
                Console.WriteLine("Login " + login + " Password " + vs + " " +vs1 + " " + vs2 + " " + vs3 + " " + vs4 + " " + vs5 + " " + vs6 + " " + vs7 + " " + vs8 + " " + vs9 + " " + vs10);
                if (increase == Math.Pow(256, symbols))
                {
                    function++;
                    increase = 0;
                }
                if (vs == password)
                {
                    Console.WriteLine("Login "+  login + " Password " +  password + " Win");
                    cycle = 1;

                }
                if (vs1 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs2 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs3 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs4 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs5 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs6 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs7 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs8 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs9 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
                if (vs10 == password)
                {
                    Console.WriteLine("Login " + login + " Password " + password + " Win");
                    cycle = 1;

                }
            }

        }
    }
}