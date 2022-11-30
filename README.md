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
|                         Method | Width | Height | Iterations |      Mean |     Error |    StdDev | Allocated |
|------------------------------- |------ |------- |----------- |----------:|----------:|----------:|----------:|
|                 ComputeSharpBM |  3840 |   2160 |         10 | 14.897 ms | 0.2685 ms | 0.2511 ms |   7.41 KB |
|                     ParallelBM |  3840 |   2160 |         10 | 21.249 ms | 0.3579 ms | 0.4778 ms |  61.94 KB |
| CommunityToolkitParallelHelper |  3840 |   2160 |         10 |  8.751 ms | 0.1696 ms | 0.1503 ms |  53.67 KB |
