﻿using Devscord.DiscordFramework.Middlewares.Contexts;
using Discord.WebSocket;

namespace Devscord.DiscordFramework.Middlewares.Factories
{
    internal class ChannelContextFactory : IContextFactory<ISocketMessageChannel, ChannelContext>
    {
        public ChannelContext Create(ISocketMessageChannel socketChannel)
        {
            return new ChannelContext(socketChannel.Id, socketChannel.Name);
        }
    }
}
