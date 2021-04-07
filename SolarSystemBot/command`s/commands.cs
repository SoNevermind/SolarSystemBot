using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace SolarSystemBot.command_s
{
    public abstract class commands
    {
        public abstract string[] Names { get; set; }

        public abstract void Execute(Message messege, TelegramBotClient client);

        public bool Contains(string messege)
        {
            foreach (var mess in Names)
            {
                if (messege.Contains(mess))
                {
                    return true;
                }

            }return false;
        }


    }
}
