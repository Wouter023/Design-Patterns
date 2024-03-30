using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class SubSystem
    {
        private Logger logger;
        public SubSystem() 
        { 
            logger = Logger.GetInstance();
            DoSomeWork();
            DoSomeMoreWork();
        }

        public void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "doing some more work");
        }

        public void DoSomeWork()
        {
            logger.Log("SubSystem", "doing some work");
        }
    }
}
