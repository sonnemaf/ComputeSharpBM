using ComputeSharp;
/// <summary>
/// The sample kernel that multiples all items by two.
/// </summary>
[EmbeddedBytecode(DispatchAxis.X)]
internal readonly partial struct MultiplyByTwo : IComputeShader {

    private readonly ReadWriteBuffer<float> _buffer;

    public MultiplyByTwo(ReadWriteBuffer<float> buffer) {
        _buffer = buffer;
    }

    /// <inheritdoc/>
    public void Execute() {
        this._buffer[ThreadIds.X] *= 2;
    }
}
