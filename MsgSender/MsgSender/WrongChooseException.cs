using System;
namespace MsgSender
{
    public class WrongChooseException:Exception
    {
        public WrongChooseException(string msg):base(msg)
        {
            
        }
    }
}
