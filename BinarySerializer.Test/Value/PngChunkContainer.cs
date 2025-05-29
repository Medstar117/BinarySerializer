using BinarySerialization.Attributes;

namespace BinarySerialization.Test.Value
{
    public class PngChunkContainer
    {
        [FieldOrder(0)]
        [FieldEndianness(Constants.Endianness.Big)]
        public int Length { get; set; }

        [FieldOrder(1)]
        [FieldCrc32(nameof(Crc), Polynomial = 0x04c11db7)]
        [FieldEndianness(Constants.Endianness.Big)]
        public PngChunkPayload Payload { get; set; }

        [FieldOrder(2)]
        [FieldEndianness(Constants.Endianness.Big)]
        public uint Crc { get; set; }
    }
}
