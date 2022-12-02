using ComputeSharp;

/// <summary>
/// The sample kernel that multiples all items by two.
/// </summary>
[EmbeddedBytecode(DispatchAxis.XY)]
internal readonly partial struct MultiplyByTwo : IComputeShader {

    private readonly ReadWriteBuffer<float> _buffer;
    private readonly int _width;

    public MultiplyByTwo(ReadWriteBuffer<float> buffer, int width) {
        _buffer = buffer;
        _width = width;
    }

    /// <inheritdoc/>
    public void Execute() {
        this._buffer[ThreadIds.X + ThreadIds.Y * _width] *= 2.0f;
    }
}

///// <summary>
///// The sample kernel that multiples all items by two.
///// </summary>
//[EmbeddedBytecode(DispatchAxis.X)]
//internal readonly partial struct MultiplyByTwo : IComputeShader {

//    private readonly ReadWriteBuffer<float> _buffer;

//    public MultiplyByTwo(ReadWriteBuffer<float> buffer) {
//        _buffer = buffer;
//    }

//    /// <inheritdoc/>
//    public void Execute() {
//        this._buffer[ThreadIds.X] *= 2.0f;
//    }
//}