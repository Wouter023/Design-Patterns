using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class BatchProcessor
    {
        private List<BigDataLoader> loaders = new List<BigDataLoader>();

        public void AddDataLoader(BigDataLoader bigDataLoader)
        {
            loaders.Add(bigDataLoader);
        }
        public void ProcessData()
        {
            foreach (BigDataLoader loader in loaders) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[ETL-proces started]");
                Console.ResetColor();
                loader.ETL();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[ETL-proces finished]\n");
                Console.ResetColor();
            }
        }
    }
}
