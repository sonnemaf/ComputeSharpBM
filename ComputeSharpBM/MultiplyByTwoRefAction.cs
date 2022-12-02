using CommunityToolkit.HighPerformance.Helpers;
using System.Numerics;

readonly struct MultiplyByTwoRefAction : IRefAction<float> {
    public void Invoke(ref float x) => x *= 2.0f;
}

readonly struct MultiplyVectorByTwoRefAction : IRefAction<Vector<float>> {
    public void Invoke(ref Vector<float> x) => x *= 2.0f;
}