using System.Net.NetworkInformation;

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
            List<Character> characters = new List<Character>();
            characters.Add(new Queen());
            characters.Add(new Troll());
            characters.Add(new King());
            characters.Add(new Knight());
            foreach (Character character in characters)
                character.Fight();
            Console.WriteLine();
            // change weapon of knight to axe
            characters[3].Weapon = new AxeBehaviour();
            foreach (Character character in characters)
                character.Fight();
        }

        int ReadInt(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        int ReadInt(string question, int min, int max)
        {
            int value;
            do
            {
                value = ReadInt(question);
            }
            while (value < min || value > max);

            return value;
        }

        string ReadString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}