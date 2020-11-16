using Microsoft.Extensions.Configuration;
using Simple_PublisherApp.Entities;
using Simple_PublisherApp.Entities.Interfaces;
using Simple_PublisherApp.Manager;
using System;

namespace Simple_PublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var connectionstring = config["ConnectionString"];

            //Console.WriteLine(connectionstring);

            //Console.ReadKey();

            IPublisherManager publisherManager = new PublisherManager(connectionstring);

            //int result = publisherManager.Create(new Entities.Publisher
            //{
            //    PublisherId = 1,
            //    Name = "Andrei"
            //});

            //Publisher publisher = publisherManager.Read(1);

            int result2 = publisherManager.Update(new Publisher
            {
                PublisherId = 1,
                Name = "Vlad"
            });

        }
    }
}
