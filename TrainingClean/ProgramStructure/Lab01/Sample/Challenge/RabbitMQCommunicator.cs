using System;
using System.Text;
using RabbitMQ.Client;
using ProgramStructure.Lab01.Sample.Common;
using Newtonsoft.Json;

namespace ProgramStructure.Lab01.Sample.Challenge
{
    class RabbitMQCommunicator
    {
        public void SendMessage(String input, String exchangeName, String routingKey) { 

            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://userName:password@hostName:portNumber/virtualHost");

			// fancy message transformation business logic
			Message message = new Message();
            message.SomeText = "The user said: " + input;
			message.SomeValue = input.Length + 42;

            DateTime dateBefore30Days = DateTime.Now.AddDays(-30);
            message.SomeDate=dateBefore30Days;

            string messageTxt = JsonConvert.SerializeObject(message);
            byte[] messageBodyBytes = Encoding.ASCII.GetBytes(messageTxt); 

            IConnection conn = factory.CreateConnection();
            IModel channel = conn.CreateModel();
            channel.BasicPublish(exchangeName, routingKey, null, messageBodyBytes);

		}
    }
}
