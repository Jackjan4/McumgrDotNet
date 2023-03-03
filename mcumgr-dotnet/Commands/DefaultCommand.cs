using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace JanRoslan.McumgrDotnet.Commands
{
    public abstract class DefaultCommand : McumgrCommand
    {
        public static new ushort GroupId = 0;

        public DefaultCommand(byte[] data) : base(Operation.Request, 0, data)
        {

        }

        internal DefaultCommand( byte[] data, Operation op) : base(op, 0, data)
        {

        }

        internal DefaultCommand() : base() 
        {

        }
    }
}
