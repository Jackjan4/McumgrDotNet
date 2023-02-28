using JanRoslan.McumgrDotnet.Commands;
using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotNet.Encoding
{
    internal interface IEncodingLayer
    {

        public EncodedMcumgrCommand EncodeMcumgrCommand(McumgrCommand command);

        public McumgrCommand DecodeMcumgrCommand(EncodedMcumgrCommand command);

        public static bool IsEncodedCommandValid(EncodedMcumgrCommand encCommand) {
            throw new NotImplementedException();
        }
    }
}
