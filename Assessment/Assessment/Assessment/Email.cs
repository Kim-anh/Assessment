using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment
{
    public class Email : Message
    {
        private string sender;

        private string subject;

        private string text;
        
        public Email(Body body1, string messageHeader1, string send, string subj, string Txt) : base(body1, messageHeader1)
        {
            sender = send;
            subject = subj;
            text = Txt;
        }


        public override Boolean textchange()
        {
            throw new NotImplementedException();
        }
    }
}