using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;

namespace JanRoslan.McumgrDotnet.Commands
{
    public abstract class McumgrCommand
    {
        public static ushort GroupId;

        public ushort group_Id;

        public byte[] Data { get; set; }

        public readonly Operation operation;

        public byte SequenceNum { get; set; }

        public static byte CommandId;

        public byte command_Id;

        public McumgrCommand(Operation op, byte sequenceNum, byte[] data)
        {
            group_Id = GroupId;
            command_Id = CommandId;
            Data = data;
            SequenceNum = sequenceNum;
            operation = op;
        }

        public McumgrCommand(Operation op, byte[] data)
        {
            group_Id = GroupId;
            command_Id = CommandId;
            Data = data;
            operation = op;
        }

        public McumgrCommand()
        {
            group_Id = GroupId;
            command_Id = CommandId;
            Data = Array.Empty<byte>();
            operation = Operation.None;
        }
    }
}
