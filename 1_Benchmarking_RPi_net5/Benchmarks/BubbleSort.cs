namespace Benchmark.Benchmarks
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] input)
        {
            if (input == null)
            {
                return null;
            }

            for (int write = 0; write < input.Length; write++)
            {
                for (int sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        var temp = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = temp;
                    }
                }
            }

            return input;
        }


    }
}