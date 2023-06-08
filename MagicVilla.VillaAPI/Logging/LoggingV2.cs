namespace MagicVilla.VillaAPI.Logging
{
    public class LoggingV2 : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR - " + message + "\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message + "\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
