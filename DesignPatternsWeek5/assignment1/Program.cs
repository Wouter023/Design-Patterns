namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Logger logger = Logger.GetInstance();

            logger.Log("Program", "starting");
            MainSystem mainSystem = new MainSystem();
            logger.Log("Program", "finishing");
        }
    }
}