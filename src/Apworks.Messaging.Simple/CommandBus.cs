﻿using Apworks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apworks.Messaging.Simple
{
    public sealed class CommandBus : MessageBus, ICommandBus
    {
        public CommandBus(IMessageSerializer messageSerializer)
            : base(messageSerializer)
        { }
    }
}
