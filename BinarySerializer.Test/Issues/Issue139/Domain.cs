using BinarySerialization.Interfaces;
using System.IO;

namespace BinarySerialization.Test.Issues.Issue139
{
    public class Domain : IBinarySerializable, IDomain
    {
        public byte Value { get; set; }

        public void Serialize(Stream stream, Constants.Endianness endianness, BinarySerializationContext serializationContext)
        {
            stream.WriteByte(5);
        }

        public void Deserialize(Stream stream, Constants.Endianness endianness, BinarySerializationContext serializationContext)
        {
            Value = (byte) stream.ReadByte();
        }
    }
}