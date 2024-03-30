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
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop HighBugdetComputerShop = new HighBudgetShop();
            Computer highBudgetComputer = HighBugdetComputerShop.AssebleComputer();
            highBudgetComputer.Test();

            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop lowBudgetComputerShop = new LowBudgetShop();
            Computer lowBudgutComputer = lowBudgetComputerShop.AssebleComputer();
            lowBudgutComputer.Test();
        }

    }
}