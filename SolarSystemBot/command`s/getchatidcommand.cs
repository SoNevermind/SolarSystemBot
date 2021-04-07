using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace SolarSystemBot.command_s
{
    class getchatidcommand : commands
    {
        public override string[] Names { get; set; } = new string[] { "get_chat_id, getchatid" };

        public override async void Execute(Message messege, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(messege.Chat.Id, $"ID данного чата: {messege.Chat.Id}");
        }
    }
}
