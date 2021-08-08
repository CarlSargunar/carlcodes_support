using System;
using MyBenchmarks.Benchmarks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    class Program
    {
        int loops = 1000;

        static void Main(string[] args)
        {

            BenchmarkRunner.Run<StringConcatAndBuilder>();        
            BenchmarkRunner.Run<Md5VsSha256>();        
            BenchmarkRunner.Run<BubbleSort>();      

            WriteLine("Complete");
        }




        private static void WriteLine(string msg)
        {
            Console.WriteLine($"{DateTime.Now} : {msg}");
        }
    }
}
