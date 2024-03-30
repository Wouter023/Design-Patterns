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
            ATMMachine machine = new ATMMachine(2000);

            string input = "";

            while(input != "stop")
            {
                Console.WriteLine($"Please enter your command: ");
                input = Console.ReadLine().ToLower();
                if(input == "stop")
                {
                    break;
                }

                switch(input)
                {
                    case "insert card":
                        machine.InsertCard();
                        break;
                    case "enter pincode":
                        machine.EnterPincode();
                        break;
                    case "reject card":
                        machine.RejectCard();
                        break;
                    case "withdraw cash":
                        machine.WithdrawCash();
                        break;
                    default:
                        Console.WriteLine("entered unknown command");
                        break;
                }
            }
        }
    }
}