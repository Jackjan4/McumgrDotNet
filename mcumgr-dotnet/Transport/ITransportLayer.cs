using JanRoslan.McumgrDotnet.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotNet.Transport
{
    internal interface ITransportLayer
    {

        void SendPacket(McumgrPacket packet);

        void SendPackets(McumgrPacket[] packets);

        McumgrPacket ReceivePacket();

        McumgrPacket SendReceivePacket(McumgrPacket packet);

        McumgrPacket SendPacketsReceive(McumgrPacket[] packets);
    }
}
