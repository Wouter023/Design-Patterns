using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;

        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
            nrOfCharsWritten = 0;
        }

        public bool CanWrite
        {
            get { return nrOfCharsWritten < maxToWrite; }
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }

        public void Write(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (CanWrite)
                {
                    Console.Write(message[i]);
                    nrOfCharsWritten++;
                }
                else
                {
                    Console.Write($"#");
                }
            }
            Console.WriteLine();
        }
    }
}
