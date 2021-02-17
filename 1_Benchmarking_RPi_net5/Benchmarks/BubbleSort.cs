using System;

namespace MyBenchmarks.Benchmarks
{
    public static class BubbleSort 
    {
        public static void DoBenchmark(int count = 1)
        {
            var input = new int[]
            {
                1, 6, 3, 6, 32, 2, 5, 2, 4, 67, 2, 3, 4, 252, 4, 6, 4, 3, 52342, 3, 24163763, 345, 4352345, 345, 54, 4,
                65, 3, 2, 453, 3525, 4, 62, 43, 45
            };

            for (int i = 0; i < count; i++)
            {
                var output = Sort(input);
            }
        }

        private static int[] Sort(int[] input)
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