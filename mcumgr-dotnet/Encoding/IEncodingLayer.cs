using JanRoslan.McumgrDotnet.Commands;
using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotNet.Encoding
{
    public interface IEncodingLayer
    {

        public EncodedMcumgrCommand EncodeMcumgrCommand(McumgrCommand command);

        public McumgrCommand DecodeMcumgrCommand(EncodedMcumgrCommand command);

        public T DecodeMcumgrCommand<T>(EncodedMcumgrCommand command) where T : McumgrCommand;

        public bool IsEncodedCommandValid(EncodedMcumgrCommand encCommand, McumgrCommand command);
    }
}
