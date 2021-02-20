``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.7 (19H2) [Darwin 19.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


```
| Method |    N |     Mean |     Error |    StdDev |
|------- |----- |---------:|----------:|----------:|
| **Sha256** |  **100** | **2.090 μs** | **0.0416 μs** | **0.0707 μs** |
|    Md5 |  100 | 1.616 μs | 0.0086 μs | 0.0072 μs |
| **Sha256** | **1000** | **1.990 μs** | **0.0124 μs** | **0.0116 μs** |
|    Md5 | 1000 | 1.593 μs | 0.0069 μs | 0.0064 μs |
