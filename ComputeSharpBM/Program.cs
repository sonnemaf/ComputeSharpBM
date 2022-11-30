using BenchmarkDotNet.Running;
using ConsoleApp155.Helpers;

BenchmarkRunner.Run<BM>();
return;

var bm = new BM();
bm.Size = 10;
bm.Iterations = 2;
bm.Setup();

// Print the initial matrix
Formatting.PrintMatrix(bm.MyArray, 10, 10, "BEFORE");

bm.ComputeSharpBM();
//bm.ParallelBM();
//bm.CommunityToolkitParallelHelper();

// Print the updated matrix
Formatting.PrintMatrix(bm.MyArray, 10, 10, "AFTER");
