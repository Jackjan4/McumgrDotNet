using JanRoslan.McumgrDotnet.Commands;
using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotNet.Encoding
{
    internal class SMPEncoder : IEncodingLayer
    {

        public SMPEncoder() { 
        }

        public McumgrCommand DecodeMcumgrCommand(EncodedMcumgrCommand command)
        {
            throw new NotImplementedException();
        }

        public EncodedMcumgrCommand EncodeMcumgrCommand(McumgrCommand command)
        {
            throw new NotImplementedException();
        }

        public static bool IsEncodedCommandValid(EncodedMcumgrCommand encCommand)
        {
            return true;
        }
    }
}
