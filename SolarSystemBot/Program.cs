using System;
using Telegram.Bot;

namespace SolarSystemBot
{
    class Program
    {
        private static TelegramBotClient client;

        static void Main(string[] args)
        {
            client = new TelegramBotClient(Config.Token);
            client.StartReceiving();
            client.OnMessage += OnMessegeHandler;
            Console.WriteLine("[Log]: Bot started");
            Console.ReadLine();
            client.StopReceiving();

        }
    }
}
