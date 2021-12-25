using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int Account_Id { get; set; }

        // Navigation reference property cho khóa ngoại đến Account
        //[DisplayName("Khách hàng")]
        public Account Account { get; set; }

        public int Product_Id { get; set; }

        // Navigation reference property cho khóa ngoại đến Product
        //[DisplayName("Sản phẩm")]
        public Product Product { get; set; }

        //[DisplayName("Số lượng")]
        //[Required(ErrorMessage = "{0} không được bỏ trống")]
        //[DefaultValue(1)]
        public int Quantity { get; set; } = 1;
    }
}
