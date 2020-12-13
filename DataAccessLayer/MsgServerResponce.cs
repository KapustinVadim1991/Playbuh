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
        public string MessageText { get; private set; }

        public MsgServerResponce(bool isSucceed, string message)
        {
            IsSucceed = isSucceed;
            MessageText = message;
        }
    }
}
