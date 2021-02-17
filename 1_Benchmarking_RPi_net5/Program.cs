using System;
using Benchmark.Benchmarks;

namespace Benchmark
{
    class Program
    {
        // Benchmarks
        BubbleSort bubbleSort = new BubbleSort();


        static void Main(string[] args)
        {
            WriteLine("Starting Benchmarking Process");
        }


        private static void WriteLine(string msg);
        {
            Console.WriteLine($" : {msg}");
        }
    }
}
