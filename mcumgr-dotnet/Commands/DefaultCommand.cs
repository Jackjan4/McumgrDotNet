using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace JanRoslan.McumgrDotnet.Commands
{
    public abstract class DefaultCommand : McumgrCommand
    {
        public static ushort DefaultGroupId = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandId"></param>
        /// <param name="data"></param>
        /// <param name="op"></param>
        internal DefaultCommand(byte commandId, byte[] data, Operation op) : base(DefaultGroupId, commandId, op, 0, data)
        {

        }
    }
}
