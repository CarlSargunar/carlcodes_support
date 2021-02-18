using System;
using MyBenchmarks.Benchmarks;
using BenchmarkDotNet.Attributes;

namespace MyBenchmarks
{
    class Program
    {
        int loops = 1000;

        void Main(string[] args)
        {
            #region Create Test instances
            var bubbleSort = new BubbleSort();
            #endregion

        

            WriteLine($"Starting Benchmarking Process : {loops} iteration(s) per test");
            var summary = BenchmarkRunner.Run<bubbleSort>();
            

            WriteLine("Complete");
        }




        private static void WriteLine(string msg)
        {
            Console.WriteLine($"{DateTime.Now} : {msg}");
        }
    }
}
