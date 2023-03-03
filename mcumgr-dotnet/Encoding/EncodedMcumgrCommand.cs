using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotnet.Encoding
{
    internal class EncodedMcumgrCommand
    {
        public readonly byte[] EncodedCommand;
        public readonly TransferEncoding encoding;

        public EncodedMcumgrCommand(byte[] encodedCommand, TransferEncoding encoding)
        {
            EncodedCommand = encodedCommand;
            this.encoding = encoding;
        }
    }
}
