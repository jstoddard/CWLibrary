using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWLibrary
{
    abstract class WaveChunk
    {
        public char[] ChunkId { get; set; }
        public uint ChunkSize { get; set; }

        public abstract byte[] ToBytes();
    }
}
