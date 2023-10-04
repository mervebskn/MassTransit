using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ResultMessage : IMessage
    {
        public string text { get; set; }
        public bool isSuccess { get; set; }
        public string messageType { get; set; }
        public string title { get; set; }
    }
    //Shared : iki yazılım sistemi arasında gerçekleştirilecek iletişimin mesaj formatını barındıracak..
}
