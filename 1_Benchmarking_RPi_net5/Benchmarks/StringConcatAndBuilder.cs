using System.Text;
using BenchmarkDotNet.Attributes;

namespace MyBenchmarks.Benchmarks
{
    public class StringConcatAndBuilder
    {
        [Params(1, 5, 10, 50, 100, 500)]
        public int Loops;

        [Benchmark]
        public string StringConcat()
        {
            string result = string.Empty;
            for (int i = 0; i < Loops; ++i)
                result = string.Concat(result, i.ToString());
            return result;
        }

        [Benchmark]
        public string StringBuilder()
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < Loops; ++i)
                sb.Append(i.ToString());
            return sb.ToString();
        }
    }
}