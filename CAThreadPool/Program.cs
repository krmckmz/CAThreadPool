class Program
{
    public static void Main(string[] args)
    {
        ThreadPool.QueueUserWorkItem(ThreadProc);
        Console.WriteLine("Main thread does work then sleeps");
        Thread.Sleep(1000);
        var isThreadPoolThread = Thread.CurrentThread.IsThreadPoolThread;
        Console.WriteLine(isThreadPoolThread);

        Console.WriteLine("Main thread exists");
    }
    static void ThreadProc(Object stateInfo)
    {
        var isThreadPoolThread = Thread.CurrentThread.IsThreadPoolThread;
        Console.WriteLine(isThreadPoolThread);
        Console.WriteLine("Hello from thread pool");
    }
}