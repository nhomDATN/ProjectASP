using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }

        public int Invoice_Id { get; set; }

        // Navigation reference property cho khóa ngoại đến Invoice
        //[DisplayName("Hóa đơn")]
        [ForeignKey("Invoice_Id")]
        public Invoice Invoice { get; set; }

        public int Product_Id { get; set; }

        // Navigation reference property cho khóa ngoại đến Product
        //[DisplayName("Sản phẩm")]
        [ForeignKey("Product_Id")]
        public Product Product { get; set; }

        //[DisplayName("Số lượng")]
        //[DefaultValue(1)]
        public int Quantity { get; set; } = 1;

        //[DisplayName("Đơn giá")]
        //[DefaultValue(0)]
        public int UnitPrice { get; set; } = 0;
    }
}
