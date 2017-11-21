using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment
{
    public class SMS : Message
    {
        private string Sender;
        private string Text;

        public SMS(Body body1, string messageHeader1) : base(body1,messageHeader1)
        {
            
        }



        public override Boolean textchange()
        {
            throw new NotImplementedException();
        }

    }
}