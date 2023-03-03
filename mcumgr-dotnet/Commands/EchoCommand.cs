using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotnet.Commands
{
    public class EchoCommand : DefaultCommand
    {

        public static new byte CommandId = 0;

        public EchoCommand(string command) : base(System.Text.Encoding.ASCII.GetBytes(command)) {
            
        }

        internal EchoCommand(string command, Operation op) : base(System.Text.Encoding.ASCII.GetBytes(command), op)
        {

        }

        internal EchoCommand() : base(Array.Empty<byte>(), Operation.None)
        {

        }

        public static EchoCommand CastEchoCommand(McumgrCommand command)
        {
            // TODO if up-casting is not allowed
            return (EchoCommand)command;
        }
    }
}
