using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class MainSystem
    {
        private Logger logger;
        private SubSystem subSystem;
        public MainSystem()
        {
            logger = Logger.GetInstance();
            DoSomeMainWork();
            subSystem = new SubSystem();
        }

        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
        }
    }
}
