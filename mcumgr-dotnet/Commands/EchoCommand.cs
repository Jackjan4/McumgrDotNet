using JanRoslan.McumgrDotnet.Encoding;
using System;
using System.Collections.Generic;
using System.Text;

namespace JanRoslan.McumgrDotnet.Commands
{
    internal class EchoCommand : McumgrCommand
    {
        public EchoCommand(string command) : base(0, 0, System.Text.Encoding.ASCII.GetBytes(command), Operation.Request) {
            
        }

        internal EchoCommand(string command, Operation op) : base(0, 0, System.Text.Encoding.ASCII.GetBytes(command), op)
        {

        }
    }
}
