using System;
using System.Collections.Generic;
using System.Text;
using System.Formats.Cbor;
using JanRoslan.McumgrDotnet.Packaging;
using JanRoslan.McumgrDotnet.Encoding;

namespace JanRoslan.McumgrDotNet.Packaging
{
    public class SerialPackager : IPacketLayer
    {
        public SerialPackager()
        {

        }

        public McumgrPacket PackCommand(EncodedMcumgrCommand encodedCommand)
        {

            return null;
        }

        public EncodedMcumgrCommand UnpackCommand(McumgrPacket packet)
        {
            throw new NotImplementedException();
        }
    }
}
