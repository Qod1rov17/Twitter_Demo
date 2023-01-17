using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set;}
       
    }

}
