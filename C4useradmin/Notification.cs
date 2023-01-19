using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44444
{
    internal class Notification
    {
        public Notification(int idNotificaiton, string text, string fromUser)
        {
            this.idNotificaiton = idNotificaiton;
            this.text = text;
            this.fromUser = fromUser;
          
        }

        private int idNotificaiton;
        private string text = "";
        private string fromUser = "";
        public int Id
        {
            get { return idNotificaiton; }
            set { idNotificaiton = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public string FromUser
        {
            get { return fromUser; }
            set { fromUser = value; }
        }
        public override string ToString()
        {
            return $"ID : {idNotificaiton}\nLike Count : {text}\nView Count : {fromUser}";
        }
    }
}
