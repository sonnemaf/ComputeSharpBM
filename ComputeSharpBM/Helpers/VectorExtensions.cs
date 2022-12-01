using System.Numerics;
using System.Runtime.InteropServices;

public static class VectorExtensions
{
    public static Span<Vector<T>> AsVector<T>(this Span<T> span) where T : struct
    {
        return MemoryMarshal.Cast<T, Vector<T>>(span);
    }

    public static ReadOnlySpan<Vector<T>> AsVector<T>(this ReadOnlySpan<T> span) where T : struct
    {
        return MemoryMarshal.Cast<T, Vector<T>>(span);
    }
}
