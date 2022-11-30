using BenchmarkDotNet.Running;
using ConsoleApp155.Helpers;

BenchmarkRunner.Run<BM>();
return;

using var bm = new BM();
bm.Size = 1000;
bm.Iterations = 2;
bm.Setup();

// Print the initial matrix
Formatting.PrintMatrix(bm.MyArray, bm.Size, bm.Size, "BEFORE");

bm.ComputeSharpBM();
//bm.ParallelBM();
//bm.CommunityToolkitParallelHelper();

// Print the updated matrix
Formatting.PrintMatrix(bm.MyArray, bm.Size, bm.Size, "AFTER");
