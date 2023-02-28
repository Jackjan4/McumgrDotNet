using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotnet.Encoding
{
    internal class EncodedMcumgrCommand
    {
        public readonly byte[] EncodedCommand;

        public EncodedMcumgrCommand(byte[] encodedCommand)
        {
            EncodedCommand = encodedCommand;
        }
    }
}
