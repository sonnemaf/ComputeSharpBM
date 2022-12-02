using BenchmarkDotNet.Running;
using ConsoleApp155.Helpers;

BenchmarkRunner.Run<BM>();
return;

using var bm = new BM();
bm.Width = 12;
bm.Height = 10;
bm.Iterations = 2;
bm.Setup();

// Print the initial matrix
Formatting.PrintMatrix(bm.MyArray, bm.Width, bm.Height, "BEFORE");

bm.ComputeSharpBM();
//bm.ParallelBM();
//bm.CommunityToolkitParallelHelper();
//bm.vectorBM();
//bm.ParallelHelperVectorBM();

// Print the updated matrix
Formatting.PrintMatrix(bm.MyArray, bm.Width, bm.Height, "AFTER");