using System;
using MyBenchmarks.Benchmarks;
using BenchmarkDotNet.Attributes;

namespace MyBenchmarks
{
    class Program
    {


        static void Main(string[] args)
        {
            #region Create Test instances
            var bubbleSort = new BubbleSort();
            #endregion

            
            var loops = 10000;

            WriteLine("Starting Benchmarking Process : {loops} iteration(s) per test");

            WriteLine("Bubble Sort an array of 1000 integers");
            bubbleSort.DoBenchmark(loops);




            WriteLine("Complete");
        }




        private static void WriteLine(string msg)
        {
            Console.WriteLine($"{DateTime.Now} : {msg}");
        }
    }
}
