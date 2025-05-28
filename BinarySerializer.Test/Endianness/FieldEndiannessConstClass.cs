using BinarySerialization.Attributes;

namespace BinarySerialization.Test.Endianness
{
    public class FieldEndiannessConstClass
    {
        [FieldEndianness(Constants.Endianness.Big)]
        public int Value { get; set; }
    }
}
