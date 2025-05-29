using BinarySerialization.Attributes;
using BinarySerialization.Interfaces;
using System;
using System.IO;

namespace BinarySerialization.Test.Issues.Issue55
{
    public class CustomSerializable : IBinarySerializable
    {
        [Ignore]
        public byte Value;

        public void Serialize(Stream stream, Constants.Endianness endianness, BinarySerializationContext serializationContext)
        {
            stream.WriteByte(Value);
        }

        public void Deserialize(Stream stream, Constants.Endianness endianness, BinarySerializationContext serializationContext)
        {
            var readByte = stream.ReadByte();
            if (readByte == -1) throw new EndOfStreamException();
            Value = Convert.ToByte(readByte);
        }
    }
}