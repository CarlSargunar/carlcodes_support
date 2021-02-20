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
            // #region Create Test instances
            // var bubbleSort = new BubbleSort();
            // #endregion

            var summary = BenchmarkRunner.Run<StringConcatAndBuilder>();        
            var summary2 = BenchmarkRunner.Run<Md5VsSha256>();        
            var summary3 = BenchmarkRunner.Run<BubbleSort>();        

            // WriteLine($"Starting Benchmarking Process : {loops} iteration(s) per test");
            // var summary = BenchmarkRunner.Run<bubbleSort>();
            

            WriteLine("Complete");
        }




        private static void WriteLine(string msg)
        {
            Console.WriteLine($"{DateTime.Now} : {msg}");
        }
    }
}
