using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystemBot.command_s
{
    class getchatidcommand : commands
    {
        public override string[] Names { get; set; } = new string[] { "get_chat_id, getchatid" };

        public override async void Execute(Message messege, TelegramBotClient client)
        {
            await client.SendTextMessegAysync(messege.Chat.Id, $"ID данного чата: {messege.Chat.Id}");
        }
    }
}
