using System;
using MyBenchmarks.Benchmarks;
using BenchmarkDotNet.Attributes;

namespace MyBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Starting Benchmarking Process");

            WriteLine("Bubble Sort");
            BubbleSort.DoBenchmark(100000);
            

            WriteLine("Complete");
        }




        private static void WriteLine(string msg)
        {
            Console.WriteLine($"{DateTime.Now} : {msg}");
        }
    }
}
