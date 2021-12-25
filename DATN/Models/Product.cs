using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class Product
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Code { get; set; }

        //[DisplayName("Tên sản phẩm")]
        //[Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

        //[DisplayName("Mô tả")]
        public string Description { get; set; }

        //[DisplayName("Giá (VNĐ)")]
        //[DisplayFormat(DataFormatString = "{0:n0}")]
        //[DefaultValue(0)]
        public int Price { get; set; } = 0;

        //[DisplayName("Tồn kho")]
        //[DefaultValue(0)]
        public int Stock { get; set; } = 0;

        public int ProductType_Id { get; set; }

        // Navigation reference property cho khóa ngoại đến ProductType
        //[DisplayName("Loại sản phẩm")]
        public ProductType ProductType { get; set; }

        public int Promotion_Id { get; set; }

        public Promotion Promotion { get; set; }

        //[DisplayName("Ảnh minh họa")]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        //[DisplayName("Còn hiệu lực")]
        //[DefaultValue(1)]
        public int Status { get; set; } = 1;

        // Collection reference property cho khóa ngoại từ InvoiceDetail
        public List<InvoiceDetail> InvoiceDetails { get; set; }

        public List<Cart> Carts { get; set; }
    }
}
