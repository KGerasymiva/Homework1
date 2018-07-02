using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PostData
    {
        public Post Post { get; set; }
        public IEnumerable<Comment> Comments { get; set; } 
    }
}
