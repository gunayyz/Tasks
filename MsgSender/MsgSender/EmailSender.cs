using System;
namespace MsgSender
{
    public class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            //string msg = Console.ReadLine();
            Console.WriteLine("From email");
        }
    }
}
