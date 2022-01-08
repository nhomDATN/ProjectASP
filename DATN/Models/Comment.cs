using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int Product_Id { get; set; }

        public Product Product { get; set; }

        public int Account_Id { get; set; }

        public Account Account { get; set; }

        public DateTime CommentDate { get; set; }

        public int Status { get; set; } = 1;
    }
}
