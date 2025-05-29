using BinarySerialization.Attributes;
using Zookeeper.Structs;

namespace BinarySerialization.Test.Issues.Issue170
{
    class TestClass
    {
        [FieldOrder(0)]
        [SubtypeDefault(typeof(IPAddressEx))]
        public IIPAddressEx ipAddress { get; set; } = new IPAddressEx();

        [FieldOrder(1)]
        [SubtypeDefault(typeof(IPEndPointEx))]
        public IIPEndPointEx endPoint { get; set; } = new IPEndPointEx();
    }
}
