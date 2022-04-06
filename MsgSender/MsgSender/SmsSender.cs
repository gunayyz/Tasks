using System;
namespace MsgSender
{
    public class SmsSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("from SMS");
        }
    }
}