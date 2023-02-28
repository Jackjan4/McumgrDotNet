using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;

namespace JanRoslan.McumgrDotnet.Commands
{
    internal abstract class McumgrCommand
    {
        public byte GroupId { get; set; }

        public byte CommandId { get; set; }

        public byte[] Data { get; set; }

        public readonly Operation operation;

        public McumgrCommand(byte groupId, byte commandId, byte[] data, Operation op)
        {
            GroupId = groupId;
            CommandId = commandId;
            Data = data;
            operation = op;
        }
    }
}
