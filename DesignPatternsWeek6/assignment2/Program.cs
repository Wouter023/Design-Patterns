namespace assignment2
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
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            Factory highComputerFactory = new HighFactory();
            ComputerShop highComputerShop = new ComputerShop(highComputerFactory);
            Computer highBudgetComputer = highComputerShop.AssebleComputer();
            highBudgetComputer.Test();

            Console.WriteLine("[shop creating cheap computers]");
            Factory lowComputerFactory = new CheapFactory();
            ComputerShop lowComputerShop = new ComputerShop(lowComputerFactory);
            Computer lowBudgutComputer = lowComputerShop.AssebleComputer();
            lowBudgutComputer.Test();
        }

    }
}