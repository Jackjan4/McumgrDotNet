using JanRoslan.McumgrDotnet.Encoding;
using JanRoslan.McumgrDotnet.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotNet.Packaging
{
    public interface IPacketLayer
    {

        public McumgrPacket PackCommand(EncodedMcumgrCommand encodedCommand);

        public EncodedMcumgrCommand UnpackCommand(McumgrPacket packet);
    }
}
