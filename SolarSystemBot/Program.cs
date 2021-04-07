using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Collections.Generic;
using SolarSystemBot.command_s;

namespace SolarSystemBot
{
    class Program
    {
        private static TelegramBotClient client;
        private static List<command_s.commands> command;

        static void Main(string[] args)
        {

            client = new TelegramBotClient(Config.Token);
            command = new List<command_s.commands> ();
            
            command.Add(new GetMyIdCommands());
            command.Add(new getchatidcommand());

            client.StartReceiving();
            client.OnMessage += OnMessageHendler;
            Console.WriteLine("[Log]: Bot started");
            Console.ReadLine();
            client.StopReceiving();


        }

        private static async void OnMessageHendler(object sender, MessageEventArgs eventsArgs)
        {
            var message = eventsArgs.Message;

            if(message.Text != null)
            {
                Console.WriteLine("[Log]: Пришло новое сообщение! От: " + message.From.FirstName + " " + message.From.LastName + " с текстом: " + message.Text);
                await client.SendTextMessageAsync(message.Chat.Id, message.Text, replyToMessageId: message.MessageId);
            }

        }
    }
}
