using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWLibrary
{
    class FormatChunk : WaveChunk
    {
        public short CompressionCode { get; set; }
        public short NumChannels { get; set; }
        public uint SampleRate { get; set; }
        public uint BytesPerSecond { get; set; }
        public short BlockAlign { get; set; }
        public short SignificantBits { get; set; }

        public FormatChunk()
        {
            ChunkId = "fmt ".ToCharArray();
            ChunkSize = 16;
            CompressionCode = 1;
            NumChannels = 1;
            SampleRate = 11025;
            BytesPerSecond = 22050;
            BlockAlign = 2;
            SignificantBits = 16;
        }

        public override byte[] ToBytes()
        {
            List<byte> bytes = new List<byte>();

            bytes.AddRange(Encoding.UTF8.GetBytes(ChunkId));
            bytes.AddRange(BitConverter.GetBytes(ChunkSize));
            bytes.AddRange(BitConverter.GetBytes(CompressionCode));
            bytes.AddRange(BitConverter.GetBytes(NumChannels));
            bytes.AddRange(BitConverter.GetBytes(SampleRate));
            bytes.AddRange(BitConverter.GetBytes(BytesPerSecond));
            bytes.AddRange(BitConverter.GetBytes(BlockAlign));
            bytes.AddRange(BitConverter.GetBytes(SignificantBits));

            return bytes.ToArray<byte>();
        }
    }
}
