﻿using JumpstartMenu.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace JumpstartMenu
{
    public class ReceiverEntry : IReceiverEntry
    {
        public ReceiverEntry(String name)
        {
            FriendlyName = name;
        }
        public void SendMessage(IMessage message) => Application.Current.Dispatcher.BeginInvoke((Action)(() => MessageReceived(message, new MessageReceivedEventArgsImpl(message))), DispatcherPriority.Send, null);
        public String FriendlyName { get; }
        public Type Type { get; }

        public event EventHandler<MessageReceivedEventArgs> MessageReceived;
    }

    public class ConfigurationEntry : IConfigurationEntry
    {
        public ConfigurationEntry(Object obj, String name)
        {
            Object = obj;
            FriendlyName = name;
        }

        public Object Object { get; }

        public String FriendlyName { get; }
    }

    public class MessageReceivedEventArgsImpl : MessageReceivedEventArgs
    {
        public MessageReceivedEventArgsImpl(IMessage m)
        {
            Message = m;
        }
        public override IMessage Message { get; }
    }
}
