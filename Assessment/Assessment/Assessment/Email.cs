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

        private Body Body;
        public Email(string send, string subj, string Txt)
        {
            sender = send;
            subject = subj;
            text = Txt;
        }
    }
}