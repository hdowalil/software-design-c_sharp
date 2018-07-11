using System;
using ProgramStructure.Lab01.Sample.Common;
using Newtonsoft.Json;
using System.Text;
using RabbitMQ.Client;

namespace ProgramStructure.Lab01.Sample.Solution
{
    class RabbitMQCommunicatorSLA
    {
        public Message WrapTextInMessage(String input)
        {
            Message message = new Message();
            message.SomeText = "The user said: " + input;
            message.SomeValue = input.Length + 42;

            DateTime dateBefore30Days = DateTime.Now.AddDays(-30);
            message.SomeDate = dateBefore30Days;

            return message;
        }

        public void SendMessage(Message input, string exchangeName, string routingKey)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://userName:password@hostName:portNumber/virtualHost");

            IConnection conn = factory.CreateConnection();
            IModel channel = conn.CreateModel();
            channel.BasicPublish(exchangeName, routingKey, null, ConvertMessageToJsonByteArray(input));
        }

        private byte[] ConvertMessageToJsonByteArray(Message message)
        {
            string messageTxt = JsonConvert.SerializeObject(message);
            return Encoding.ASCII.GetBytes(messageTxt);
        }
    }
}