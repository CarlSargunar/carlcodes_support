``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.7 (19H2) [Darwin 19.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


```
|       Method |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| DoBubbleSort | 271.3 μs | 1.26 μs | 1.05 μs |     - |     - |     - |         - |
