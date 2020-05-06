public class ConsoleLogger
{
    private static ConsoleLogger instance = null;

    private ConsoleLogger() { }

    public void Log(string lineToLog)
    {
        System.Console.WriteLine(lineToLog);
    }

    public static ConsoleLogger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }
    }
}
