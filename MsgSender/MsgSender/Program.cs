using System;

namespace MsgSender
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender();
            SmsSender smsSender = new SmsSender();
            Console.Write("gondermek istediyiniz mesaji daxil edin:");
            string msg=Console.ReadLine();
            Console.WriteLine("1. Send message by email \n" +
                              "2.send message by sms\n" +
                              "0. quit");
            byte choose;
            Console.Write("seciminiz:");
            choose = Convert.ToByte(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.Write(msg+" ");
                    emailSender.SendMessage();
                    
                    break;
                case 2:
                    Console.Write(msg+" ");
                    smsSender.SendMessage();
                    break;
                case 0:
                    Console.Write("exit");
                    break;

                default:
                    throw new WrongChooseException("bele secim yoxdu gecemezsin bro");
                    
            }
        }
    }
}
