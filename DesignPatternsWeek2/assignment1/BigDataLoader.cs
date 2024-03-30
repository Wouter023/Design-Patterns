using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace assignment1
{
    abstract class BigDataLoader
    {
        public void ETL()
        {
            Extract();
            Transform();
            Loader();
        }
        protected abstract void Extract();
        protected abstract void Transform();
        private void Loader() 
        {
            Console.WriteLine($"loading transformed data...");
        }
    }
}
