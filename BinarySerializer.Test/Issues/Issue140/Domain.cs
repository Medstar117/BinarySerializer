using BinarySerialization.Attributes;
using BinarySerialization.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace BinarySerialization.Test.Issues.Issue140
{
    public class Domain : IBinarySerializable, IDomain
    {
        [Ignore]
        public List<ILabel> Labels { get; }

        [Ignore]
        public string Name => ToString();

        public void Serialize(Stream stream, Constants.Endianness endianness, BinarySerializationContext context)
        {
            //Code
        }

        public void Deserialize(Stream stream, Constants.Endianness endianness, BinarySerializationContext context)
        {
            //Code
        }

    }
}
