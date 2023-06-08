namespace MagicVilla.VillaAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.WriteLine("ERROR - " + message + "\n");
            }
            else
            {
                Console.WriteLine(message + "\n");
            }
        }
    }
}
