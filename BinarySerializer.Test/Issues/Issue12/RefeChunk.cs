using BinarySerialization.Attributes;
using BinarySerialization.Constants;

namespace BinarySerialization.Test.Issues.Issue12
{
    public class RefeChunk : Chunk
    {
        [SerializeAs(SerializedType.SizedString)]
        public string SomeStuffInThisChunk { get; set; }
    }
}