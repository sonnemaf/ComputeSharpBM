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
|                 **ComputeSharpBM** | **1000** |         **10** |  **2.805 ms** | **0.0197 ms** | **0.0174 ms** |       **-** |   **7.41 KB** |
|                     ParallelBM | 1000 |         10 |  3.059 ms | 0.0532 ms | 0.0692 ms |  7.8125 |  62.76 KB |
| CommunityToolkitParallelHelper | 1000 |         10 |  1.496 ms | 0.0297 ms | 0.0330 ms |  3.9063 |  42.48 KB |
|                 **ComputeSharpBM** | **1000** |        **100** | **17.511 ms** | **0.3474 ms** | **0.4755 ms** |       **-** |   **7.42 KB** |
|                     ParallelBM | 1000 |        100 | 30.295 ms | 0.4477 ms | 0.6421 ms | 62.5000 |  629.2 KB |
| CommunityToolkitParallelHelper | 1000 |        100 | 14.092 ms | 0.0764 ms | 0.0638 ms | 46.8750 |  429.1 KB |
