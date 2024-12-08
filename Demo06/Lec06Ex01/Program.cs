// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Threading;

class Program {

    static void Main()
    {
        //Thread.Sleep(30000);
        Thread thread = new Thread(new ThreadStart(Worker));
        thread.Start();
        thread = new Thread(new ThreadStart(Worker));
        thread.Start();
        thread = new Thread(new ThreadStart(Worker));
        thread.Start();
        thread = new Thread(new ThreadStart(Worker));
        thread.Start();
        for (i = 0; i < 500;)
        {
            lock (x) {
                Console.WriteLine("Main thread: {0}", i);
                Thread.Sleep(100);
                i++;
            }
        }
    }

    static void Worker()
    {
        // Do some work in the worker thread
        for (i = 0; i < 500;)
        {
            lock (x)
            {
                Console.WriteLine("Worker thread: {0}", i);
                Thread.Sleep(70);
                i++;
            }
        }
    }
    static int i = 0;

    //void func()
    //{
    //    Console.WriteLine("i: {0}", this.i);
    //}
    static object x = new object();
}


