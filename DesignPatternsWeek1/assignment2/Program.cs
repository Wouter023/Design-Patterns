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
            Pencil pencil = new Pencil(20);
            PencilSharpener pencilSharpener = new PencilSharpener();

            string input = "";

            while(input != "stop")
            {
                input = Console.ReadLine();

                if(input == "stop")
                {
                    break;
                }
                else if(input == "sharpen")
                {
                    pencilSharpener.Sharpen(pencil);
                    Console.WriteLine($"sharpening the pencil...");
                }
                else
                {
                    pencil.Write(input);
                }
            }
        }
    }
}