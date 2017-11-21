using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assessment
{
    public abstract class Message
    {
        protected string messageHeader ;
        protected Body body;
        protected string type;

        public Message(Body body1, string messageHeader1)
        {
            body = body1;
            messageHeader = messageHeader1;
            this.detecttypemsg();
        }

        public Boolean detecttypemsg()
        {
            if (messageHeader[0]=='S'|| messageHeader[0] == 'E'|| messageHeader[0] == 'T')
            {
                if (messageHeader[0] == 'S')
                {
                    type = "SMS";
                }
                else if (messageHeader[0] == 'E')
                {
                    type = "Email";
                }else 
                {
                    type = "Tweet";
                }
                return true;
            }
            return false;
            //throw new System.NotImplementedException();
        }
    public string getMessageHeader()
        {
            return messageHeader;
        }

        public Body getBody()
        {
            return body;
        }

        public string gettype()
        {
            return type;
        }

        public abstract Boolean textchange();
    }
}