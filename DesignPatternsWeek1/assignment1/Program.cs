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
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            CheckValues(myStack);
            ProcessValues(myStack);
        }

        void AddValues(IStack stack)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = random.Next(0, 100);
                stack.Push(value);
                Console.WriteLine($"pushed {value,2}, new count: {stack.Count}");
            }
        }

        void CheckValues(IStack stack) 
        {
            int input = 0;  
            do
            {
                Console.WriteLine($"Enter a number: ");
                input = int.Parse(Console.ReadLine());
                if(input <= 0)
                {
                    break;
                }
                if (stack.Contains(input))
                {
                    Console.WriteLine($"stack contains value {input}");
                }
                else
                {
                    Console.WriteLine($"stack does not contain value {input}");
                }
            }while(input != 0);
        }

        void ProcessValues(IStack stack)
        {
            while (!stack.isEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }
    }
}