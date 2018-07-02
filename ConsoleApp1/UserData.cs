using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserData
    {
        public User User { get; set; }
        public List<PostData> Posts { get; set; }
        public List<Todo> Todos { get; set; }

    }
}
