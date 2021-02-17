using System;
using Benchmark.Benchmarks;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Starting Benchmarking Process");
            
            [Benchmark]
            BubbleSort.Sort
        }


        private static void WriteLine(string msg)
        {
            Console.WriteLine($"{DateTime.Now} : {msg}");
        }
    }
}
