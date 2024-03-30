using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Logger
    {
        private static Logger uniqueInstance;
        private int numberOfLines;

        private Logger()
        {
            numberOfLines = 0;
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();  
            }

            return uniqueInstance;
        }

        public void Log(string system, string message)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{system}] {message}");
        }
    }
}
