﻿using JanRoslan.McumgrDotnet.Commands;
using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.Text;
using System.Xml.XPath;

namespace JanRoslan.McumgrDotNet.Encoding
{
    public class SmpEncoder : IEncodingLayer
    {

        public SmpEncoder() { 
        }

        public McumgrCommand DecodeMcumgrCommand(EncodedMcumgrCommand command)
        {
            byte b_operation = command.EncodedCommand[0];
            byte b_flags = command.EncodedCommand[1];
            ushort b_dataLength = BitConverter.ToUInt16(command.EncodedCommand, 2);
            ushort b_groupId = BitConverter.ToUInt16(command.EncodedCommand, 4);
            byte b_sequenceNum = command.EncodedCommand[6];
            byte b_commandId = command.EncodedCommand[7];

            byte[] b_data = Array.Empty<byte>();
            if (b_dataLength > 0)
            {
                b_data = new byte[b_dataLength];
                Array.Copy(command.EncodedCommand, 8, b_data, 0, b_dataLength);
            }

            //McumgrCommand result = new McumgrCommand(b_groupId, b_commandId, (Operation)b_operation, b_data);
            return null;//result;
        }

        public T DecodeMcumgrCommand<T>(EncodedMcumgrCommand command) where T : McumgrCommand
        {
            McumgrCommand result = DecodeMcumgrCommand(command);
            return (T)result;
        }

        public EncodedMcumgrCommand EncodeMcumgrCommand(McumgrCommand command)
        {
            byte[] cborData = command.GetDataAsCbor();

            byte[] resultBytes = new byte[8 + cborData.Length];

            resultBytes[0] = (byte)command.operation; // Op code
            resultBytes[1] = 0; // Flags; Not used by Zephyr
            resultBytes[2] = (byte)(((ushort)cborData.Length) >> 8);// Data Length MSB
            resultBytes[3] = (byte)(((ushort)cborData.Length) & 0xFF); // Data length LSB
            resultBytes[4] = (byte)(command.GroupId >> 8); // Group Id MSB
            resultBytes[5] = (byte)(command.GroupId & 0xFF); // Group Id LSB
            resultBytes[6] = (byte)command.SequenceNum;// Sequence Num (TODO: SequenceNum can be NULL)
            resultBytes[7] = command.CommandId; // Command Id


            for(int i = 0; i < cborData.Length; i++)
            {
                resultBytes[i + 8] = cborData[i];
            }

            EncodedMcumgrCommand result = new EncodedMcumgrCommand(resultBytes, TransferEncoding.Smp);
            return result;
        }

        public bool IsEncodedCommandValid(EncodedMcumgrCommand encCommand, McumgrCommand command)
        {
            return true;
        }
    }
}
