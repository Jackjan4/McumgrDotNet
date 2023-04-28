using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace JanRoslan.McumgrDotnet.Commands
{
    public class EchoCommand : DefaultCommand
    {

        public static byte EchoCommandId = 0;

        public string EchoText;

        public EchoCommand(string text) : base(EchoCommandId, System.Text.Encoding.ASCII.GetBytes(text), Operation.WriteRequest) {
            EchoText = text;        
        }

        internal EchoCommand(string text, Operation op) : base(EchoCommandId, System.Text.Encoding.ASCII.GetBytes(text), op)
        {
            EchoText = text;
        }

        public static EchoCommand CastEchoCommand(McumgrCommand command)
        {
            // TODO if up-casting is not allowed
            return (EchoCommand)command;
        }

        public override byte[] GetDataAsCbor()
        {
            CborWriter cborWriter = new CborWriter();

            cborWriter.WriteStartMap(1);
            cborWriter.WriteTextString("d");
            cborWriter.WriteTextString(EchoText);
            cborWriter.WriteEndMap();

            return cborWriter.Encode();
        }
    }
}
