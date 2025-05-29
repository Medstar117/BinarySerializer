using BinarySerialization.Interfaces;
using System;

namespace BinarySerialization.Test.Endianness
{
    public class EndiannessConverter : IValueConverter
    {
        public const uint LittleEndiannessMagic = 0x1A2B3C4D;
        public const uint BigEndiannessMagic = 0x4D3C2B1A;

        public object Convert(object value, object parameter, BinarySerializationContext context)
        {
            if (value == null)
                return Constants.Endianness.Little;

            var indicator = System.Convert.ToUInt32(value);

            if (indicator == LittleEndiannessMagic)
                return Constants.Endianness.Little;

            if (indicator == BigEndiannessMagic)
                return Constants.Endianness.Big;

            throw new InvalidOperationException("Invalid endian magic");
        }

        public object ConvertBack(object value, object parameter, BinarySerializationContext context)
        {
            throw new NotSupportedException();
        }
    }
}
