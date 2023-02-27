using JanRoslan.McumgrDotnet;
using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotNet.Encoding
{
    internal interface IEncodingLayer
    {

        public EncodedMcumgrCommand EncodeMcumgrCommand(McumgrCommand command)
        {
            return null;
        }

        public McumgrCommand DecodeMcumgrCommand(McumgrCommand command)
        {
            return null;
        }
    }
}
