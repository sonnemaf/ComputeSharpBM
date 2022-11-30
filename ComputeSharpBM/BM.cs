using BenchmarkDotNet.Attributes;
using CommunityToolkit.HighPerformance.Helpers;
using ComputeSharp;

[MemoryDiagnoser]
public class BM {

    public float[] MyArray = Array.Empty<float>();

    //[Params(10, 100,1000)]
    [Params(1000)]
    public int Size;

    [Params(10, 100)]
    public int Iterations;

    [GlobalSetup]
    public void Setup() {
        MyArray = Enumerable.Range(1, Size * Size).Select(static i => (float)i).ToArray();
    }

    [Benchmark]
    public void ComputeSharpBM() {
        // Create the graphics buffer
        using ReadWriteBuffer<float> gpuBuffer = GraphicsDevice.GetDefault().AllocateReadWriteBuffer(MyArray);
        
        // Run the shader
        for (int i = 0; i < Iterations; i++) {
            GraphicsDevice.GetDefault().For(MyArray.Length, new MultiplyByTwo(gpuBuffer));
        }
        
        // Get the data back
        gpuBuffer.CopyTo(MyArray);
    }

    [Benchmark]
    public void ParallelBM() {
        for (int i = 0; i < Iterations; i++) {
            Parallel.For(0, MyArray.Length, i => MyArray[i] *= 2);
        }
    }

    [Benchmark]
    public void CommunityToolkitParallelHelper() {
        for (int i = 0; i < Iterations; i++) {
            ParallelHelper.ForEach<float, MultiplyByTwoRefAction>(MyArray);
        }
    }

}
