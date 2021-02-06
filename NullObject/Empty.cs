using Moq;

namespace NullObject
{
    public static class Empty<T> where T : class
    {
        public static T Value { get; } = new Mock<T>().Object;
    }
}
