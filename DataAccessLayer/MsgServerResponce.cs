using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MsgServerResponce
    {
        public bool IsSucceed { get; private set; }
        public string Message { get; private set; }

        public MsgServerResponce(string message, bool isSucceed = false)
        {
            IsSucceed = isSucceed;
            Message = message;
        }

        public override bool Equals(object obj)
        {
            var msg = (MsgServerResponce)obj;

            if(msg.IsSucceed == IsSucceed && msg.Message == Message)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
