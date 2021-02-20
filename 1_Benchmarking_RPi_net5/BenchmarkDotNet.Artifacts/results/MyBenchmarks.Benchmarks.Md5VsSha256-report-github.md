``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.7 (19H2) [Darwin 19.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


```
| Method |    N |     Mean |     Error |    StdDev |
|------- |----- |---------:|----------:|----------:|
| **Sha256** |  **100** | **1.996 μs** | **0.0100 μs** | **0.0093 μs** |
|    Md5 |  100 | 1.600 μs | 0.0060 μs | 0.0053 μs |
| **Sha256** | **1000** | **1.991 μs** | **0.0094 μs** | **0.0088 μs** |
|    Md5 | 1000 | 1.601 μs | 0.0063 μs | 0.0056 μs |
