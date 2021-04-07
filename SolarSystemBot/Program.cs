﻿using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace SolarSystemBot
{
    class Program
    {
        private static TelegramBotClient client;

        static void Main(string[] args)
        {

            client = new TelegramBotClient(Config.Token);
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
