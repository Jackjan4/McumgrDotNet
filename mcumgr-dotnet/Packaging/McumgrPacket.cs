using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace JanRoslan.McumgrDotnet.Packaging
{
    public class McumgrPacket
    {
        public byte[] packet;


        public McumgrPacket(byte[] packet)
        {
            this.packet = packet;
        }
    }
}
