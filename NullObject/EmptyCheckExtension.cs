namespace NullObject
{
    public static class EmptyCheckExtension
    {
        public static bool IsEmpty<T>(this T nullified) where T : class =>
            ReferenceEquals(nullified, Empty<T>.Value);
    }
}
