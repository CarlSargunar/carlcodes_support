``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.7 (19H2) [Darwin 19.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


```
|        Method | Loops |        Mean |     Error |    StdDev |
|-------------- |------ |------------:|----------:|----------:|
|  **StringConcat** |     **5** |    **99.03 ns** |  **0.436 ns** |  **0.386 ns** |
| StringBuilder |     5 |    77.59 ns |  0.372 ns |  0.311 ns |
|  **StringConcat** |    **10** |   **236.35 ns** |  **4.803 ns** |  **6.412 ns** |
| StringBuilder |    10 |   131.70 ns |  1.168 ns |  1.092 ns |
|  **StringConcat** |    **50** | **1,938.21 ns** |  **7.648 ns** |  **7.154 ns** |
| StringBuilder |    50 | 1,115.92 ns |  8.334 ns |  7.388 ns |
|  **StringConcat** |   **100** | **4,784.43 ns** | **28.921 ns** | **24.150 ns** |
| StringBuilder |   100 | 2,070.07 ns | 10.762 ns |  9.540 ns |
