using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string  Name { get; set; }
        public string Avatar { get; set; }
        public string EMail { get; set; }
    }
}
