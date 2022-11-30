using BenchmarkDotNet.Attributes;
using CommunityToolkit.HighPerformance.Helpers;
using ComputeSharp;

[MemoryDiagnoser]
public class BM : IDisposable {

    public float[] MyArray = Array.Empty<float>();
    private ReadWriteBuffer<float> _gpuBuffer = null!;

    //[Params(10, 100,1000)]
    [Params(1000)]
    public int Size;

    [Params(10, 100)]
    public int Iterations;

    [GlobalSetup]
    public void Setup() {
        MyArray = Enumerable.Range(1, Size * Size).Select(static i => (float)i / 5).ToArray();

        // Create the graphics buffer
        _gpuBuffer = GraphicsDevice.GetDefault().AllocateReadWriteBuffer<float>(Size * Size);
    }

    [Benchmark]
    public void ComputeSharpBM() {
        // Write the data in
        _gpuBuffer.CopyFrom(MyArray);
        
        // Run the shader
        for (int i = 0; i < Iterations; i++) {
            GraphicsDevice.GetDefault().For(MyArray.Length, new MultiplyByTwo(_gpuBuffer));
        }

        // Get the data back
        _gpuBuffer.CopyTo(MyArray);
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

    [GlobalCleanup]
    public void Dispose() {
        _gpuBuffer.Dispose();
    }
}
