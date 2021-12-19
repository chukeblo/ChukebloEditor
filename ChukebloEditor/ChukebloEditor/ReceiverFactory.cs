﻿using System;

namespace ChukebloEditor.CommandReceiver
{
    public static class ReceiverFactory
    {
        public static ICommandReceiver GenerateReceiver(ReceiverType type, object parameter)
        {
            switch (type)
            {
                case ReceiverType.Save:
                    return new SaveCommandReceiver(parameter);
                default:
                    throw new InvalidOperationException("not supported receiver type");
            }
        }
    }
}
