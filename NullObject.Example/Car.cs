namespace NullObject.Example
{
    public class Car
    {
        public Engine Engine { get;set; } = Empty<Engine>.Value;
    }
}
