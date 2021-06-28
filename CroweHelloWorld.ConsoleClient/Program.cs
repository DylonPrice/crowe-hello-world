using CroweHelloWorld.ConsoleClient.Helpers;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using CroweHelloWorld.Domain.Abstract;
using CroweHelloWorld.Domain.Concrete;

namespace CroweHelloWorld.ConsoleClient
{
    class Program
    {
        private static IMessageRepository _messageRepository;
        static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var appSettings = new AppSettings();
            configuration.Bind("AppSettings", appSettings);

            var message = await ApiClient.GetMessage(appSettings.AppType);
            if (appSettings.WriteLocation == "console")
            {
                Console.WriteLine(message);
            }
            else
            {
                _messageRepository = new MessageRepository();
                _messageRepository.SaveMessage(message);
            }
        }
    }
}
