using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Post
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public int Likes { get; set; }

        public IEnumerable<Comment> Comments { get; set; }=new List<Comment>();

        public override string ToString()
        {
            return ($"Id: {Id} | Created at: {CreatedAt} | Title: {Title}| Body: {Body} | UserId: {UserId} | Likes {Likes}");

        }

    }
}
