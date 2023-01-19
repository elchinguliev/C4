using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44444
{
    internal class Admin
    {
        public int Id { get; set; } 
        public string NameAdmin { get; set; }   
        public string EmailAdmin { get; set; }
        public string PasswordAdmin { get; set; }
        //public Notification NotificationsAdmin
        //{
        //    get { return notificationsAdmin; }
        //    set { notificationsAdmin = value; }
        //}
        public override string ToString()
        {
            return $"Id : {Id}\nAdmin Name : {NameAdmin}\nAdmin Email : {EmailAdmin}\nPassword Admin : {PasswordAdmin}";
        }
    }
}
