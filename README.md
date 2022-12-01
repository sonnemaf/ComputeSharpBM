# ComputeSharpBM
Benchmark comparing ComputeSharp against Parallel.For and the CommunityToolkit.HighPerformance ParallelHelper and SIMD

```
           Card name: NVIDIA GeForce GTX 1060
           Chip type: GeForce GTX 1060
      Display Memory: 14204 MB
    Dedicated Memory: 6054 MB
       Shared Memory: 8150 MB
 Driver File Version: 27.21.0014.6140 (English)
      Driver Version: 27.21.14.6140
         DDI Version: 12
      Feature Levels: 12_1,12_0,11_1,11_0,10_1,10_0,9_3,9_2,9_1
        Driver Model: WDDM 2.7
```

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```

|                         Method | Width | Height | Iterations |     Mean |    Error |   StdDev | Allocated |
|------------------------------- |------ |------- |----------- |---------:|---------:|---------:|----------:|
|                 ComputeSharpBM |  3840 |   2160 |         10 | 41.77 ms | 0.830 ms | 1.559 ms |    7624 B |
|                     ParallelBM |  3840 |   2160 |         10 | 85.72 ms | 1.705 ms | 3.118 ms |   30171 B |
| CommunityToolkitParallelHelper |  3840 |   2160 |         10 | 26.43 ms | 0.501 ms | 0.514 ms |   30022 B |
|                       VectorBM |  3840 |   2160 |         10 | 34.43 ms | 0.554 ms | 0.432 ms |      34 B |

