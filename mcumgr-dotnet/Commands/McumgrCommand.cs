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

        // According to SMP Protocol Spec Group ID is 16 bits https://docs.zephyrproject.org/3.2.0/services/device_mgmt/smp_protocol.html
        public ushort GroupId;


        // Data saved here is not encoded by e.g. CBOR
        public byte[] UnencodedData { get; set; }

        public readonly Operation operation;

        public byte? SequenceNum { get; set; }



        // According to SMP Protocol Spec Group ID is 8 bits https://docs.zephyrproject.org/3.2.0/services/device_mgmt/smp_protocol.html
        public byte CommandId;


        public McumgrCommand(ushort groupId, byte commandId, Operation op, byte sequenceNum, byte[] data)
        {
            GroupId = groupId;
            CommandId = commandId;
            UnencodedData = data;
            SequenceNum = sequenceNum;
            operation = op;
        }

        public McumgrCommand(ushort groupId, byte commandId, Operation op, byte[] data)
        {
            GroupId = groupId;
            CommandId = commandId;
            UnencodedData = data;
            SequenceNum = null;
            operation = op;
        }

        public McumgrCommand(ushort groupId, byte commandId)
        {
            GroupId = groupId;
            CommandId = commandId;
            SequenceNum = null;
            UnencodedData = Array.Empty<byte>();
            operation = Operation.None;
        }

        public abstract byte[] GetDataAsCbor();
    }
}
