using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        //[DisplayName("Mã HĐ")]
        public string Code { get; set; }

        //public int Voucher { get; set; }

        public int Account_Id { get; set; }

        // Navigation reference property cho khóa ngoại đến Account 
        //[DisplayName("Khách hàng")]
        public Account Account { get; set; }

        //[DisplayName("Ngày lập")]
        //[DataType(DataType.DateTime)]
        public DateTime IssuedDate { get; set; } = DateTime.Now;

        public DateTime DeliveDate { get; set; } 

        public double ShippingCost { get; set; }

        //[DisplayName("Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }

        //[DisplayName("SĐT giao hàng")]
        public string ShippingPhone { get; set; }

        //[DisplayName("Tổng tiền")]
        //[DisplayFormat(DataFormatString = "{0:n0}")]
        //[DefaultValue(0)]
        public int Total { get; set; } = 0;

        //[DisplayName("Còn hiệu lực")]
        //[DefaultValue(true)]
        // int: 0 đang xử lý, 1 đã xử lý, 2 đang giao, 3 đã giao, -1 hủy(trả hàng)
        public int Status { get; set; } = 0;

        // Collection reference property cho khóa ngoại từ InvoiceDetail
        public List<InvoiceDetail> InvoiceDetails { get; set; }

        public List<History> Histories { get; set; }
    }
}
