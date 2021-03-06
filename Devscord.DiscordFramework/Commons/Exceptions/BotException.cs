﻿using System;

namespace Devscord.DiscordFramework.Commons.Exceptions
{
    public abstract class BotException : Exception
    {
        public string Value { get; }

        protected BotException(string value = null)
        {
            this.Value = value;
        }
    }
}
