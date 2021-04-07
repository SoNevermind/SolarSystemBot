using System;
using Telegram.Bot.Types;
using Telegram.Bot;
using System.Collections.Generic;

namespace SolarSystemBot.command_s
{
    public class GetMyIdCommands : commands
    {
        public override string[] Names { get; set; } = { "getmyid", "get_my_id", "мой айди" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Ваш телеграм ID: " + message.From.Id);
        }
    }
}
