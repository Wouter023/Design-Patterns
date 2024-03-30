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
            BatchProcessor batchProcessor = new BatchProcessor();
            batchProcessor.AddDataLoader(new CallDataLoader());
            batchProcessor.AddDataLoader(new TwitterDataLoader());
            batchProcessor.AddDataLoader(new SensorDataLoader());
            batchProcessor.ProcessData();
        }
    }
}