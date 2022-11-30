using CommunityToolkit.HighPerformance.Helpers;

readonly struct MultiplyByTwoRefAction : IRefAction<float> {
    public void Invoke(ref float x) => x *= 2;
}
