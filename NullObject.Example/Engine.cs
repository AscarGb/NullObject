using System.Collections.Generic;

namespace NullObject.Example
{
    public class Engine
    {
        public int HorsePowers { get; set; }

        public IEnumerable<SparkPlug> SparkPlug { get; set; } = Empty<IEnumerable<SparkPlug>>.Value;
    }
}
