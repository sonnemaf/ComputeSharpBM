# ComputeSharpBM
[Benchmark](https://github.com/sonnemaf/ComputeSharpBM/blob/master/ComputeSharpBM/BM.cs) comparing [ComputeSharp](https://github.com/Sergio0694/ComputeSharp) against [Parallel.For](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.parallel.for) and the [CommunityToolkit.HighPerformance ParallelHelper](https://learn.microsoft.com/en-us/windows/communitytoolkit/high-performance/parallelhelper) and [SIMD](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector)

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



# My AMD Desktop
```

	NVIDIA GeForce GTX 1660 SUPER

	Driver version:	30.0.14.7121
	Driver date:	6/29/2021
	DirectX version:	12 (FL 12.1)
	Physical location:	PCI bus 10, device 0, function 0
```


``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
AMD Ryzen 9 3900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method | Width | Height | Iterations |      Mean | Ratio | Allocated |
|----------------------- |------ |------- |----------- |----------:|------:|----------:|
|                ArrayBM |  3840 |   2160 |         10 | 34.795 ms |  1.00 |      34 B |
|         ComputeSharpBM |  3840 |   2160 |         10 | 14.737 ms |  0.42 |    7592 B |
|             ParallelBM |  3840 |   2160 |         10 | 26.670 ms |  0.77 |   63286 B |
|       ParallelHelperBM |  3840 |   2160 |         10 |  8.623 ms |  0.25 |   56384 B |
|               VectorBM |  3840 |   2160 |         10 | 27.631 ms |  0.79 |      15 B |
| ParallelHelperVectorBM |  3840 |   2160 |         10 |  9.123 ms |  0.26 |   51860 B |

# My Intel Laptop

```
GPU 1

	NVIDIA GeForce RTX 2060 with Max-Q Design

	Driver version:	31.0.15.1700
	Driver date:	8/2/2022
	DirectX version:	12 (FL 12.1)
	Physical location:	PCI bus 1, device 0, function 0
```

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-10875H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method | Width | Height | Iterations |     Mean |   Median | Ratio | Allocated |
|----------------------- |------ |------- |----------- |---------:|---------:|------:|----------:|
|                ArrayBM |  3840 |   2160 |         10 | 37.47 ms | 36.64 ms |  1.00 |      37 B |
|         ComputeSharpBM |  3840 |   2160 |         10 | 24.36 ms | 24.35 ms |  0.65 |    7599 B |
|             ParallelBM |  3840 |   2160 |         10 | 33.37 ms | 33.26 ms |  0.90 |   46811 B |
|       ParallelHelperBM |  3840 |   2160 |         10 | 18.99 ms | 18.80 ms |  0.50 |   47969 B |
|               VectorBM |  3840 |   2160 |         10 | 20.20 ms | 20.08 ms |  0.53 |      15 B |
| ParallelHelperVectorBM |  3840 |   2160 |         10 | 18.66 ms | 18.64 ms |  0.50 |   47119 B |

