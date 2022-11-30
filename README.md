# ComputeSharpBM
Benchmark comparing ComputeSharp against Parallel.For and the CommunityToolkit.HighPerformance ParallelHelper

```
GPU 0
	NVIDIA GeForce GTX 1660 SUPER

	Driver version:	30.0.14.7121
	Driver date:	6/29/2021
	DirectX version:	12 (FL 12.1)
	Physical location:	PCI bus 10, device 0, function 0

	Utilization	2%
	Dedicated GPU memory	1.2/6.0 GB
	Shared GPU memory	0.1/16.0 GB
	GPU Memory	1.3/22.0 GB
```

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
AMD Ryzen 9 3900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                         Method | Size | Iterations |      Mean |     Error |    StdDev |    Gen0 | Allocated |
|------------------------------- |----- |----------- |----------:|----------:|----------:|--------:|----------:|
|                 **ComputeSharpBM** | **1000** |         **10** |  **2.891 ms** | **0.0502 ms** | **0.0493 ms** |       **-** |  **11.23 KB** |
|                     ParallelBM | 1000 |         10 |  3.119 ms | 0.0600 ms | 0.0800 ms |  7.8125 |   62.9 KB |
| CommunityToolkitParallelHelper | 1000 |         10 |  1.413 ms | 0.0083 ms | 0.0077 ms |  3.9063 |  42.73 KB |
|                 **ComputeSharpBM** | **1000** |        **100** | **17.475 ms** | **0.1081 ms** | **0.1011 ms** |       **-** |  **11.24 KB** |
|                     ParallelBM | 1000 |        100 | 31.362 ms | 0.5134 ms | 1.1692 ms |       - | 629.53 KB |
| CommunityToolkitParallelHelper | 1000 |        100 | 14.291 ms | 0.1626 ms | 0.1521 ms | 46.8750 | 426.34 KB |
