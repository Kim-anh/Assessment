using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment
{
    public class Tweet : Message
    {
       

        private String sender;

        private string text;

        public Tweet(Body body1, string messageHeader1, string send, string Txt) : base(body1, messageHeader1)
        {
            sender = send;
            
            text = Txt;
        }


        public override Boolean textchange()
        {
            throw new NotImplementedException();
        }
    }
}