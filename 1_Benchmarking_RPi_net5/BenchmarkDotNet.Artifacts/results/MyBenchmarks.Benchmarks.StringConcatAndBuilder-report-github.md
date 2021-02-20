``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.7 (19H2) [Darwin 19.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


```
|        Method | Loops |        Mean |     Error |    StdDev |
|-------------- |------ |------------:|----------:|----------:|
|  **StringConcat** |     **5** |    **98.10 ns** |  **0.630 ns** |  **0.590 ns** |
| StringBuilder |     5 |    76.30 ns |  0.535 ns |  0.500 ns |
|  **StringConcat** |    **10** |   **223.90 ns** |  **1.084 ns** |  **0.905 ns** |
| StringBuilder |    10 |   129.26 ns |  0.649 ns |  0.507 ns |
|  **StringConcat** |    **50** | **1,928.36 ns** | **24.430 ns** | **22.852 ns** |
| StringBuilder |    50 | 1,056.87 ns |  3.318 ns |  2.770 ns |
|  **StringConcat** |   **100** | **4,747.72 ns** | **26.385 ns** | **22.033 ns** |
| StringBuilder |   100 | 2,094.15 ns | 12.288 ns | 11.494 ns |
