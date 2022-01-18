using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class Wishlist
    {
        public int Id { get; set; }

        public int Product_Id { get; set; }

        [ForeignKey("Product_Id")]
        public Product Product { get; set; }

        public int Account_Id { get; set; }

        [ForeignKey("Account_Id")]
        public Account Account { get; set; }

        public int Status { get; set; } = 1;
    }
}
