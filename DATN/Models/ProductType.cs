using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [DisplayName("Loại sản phẩm")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Còn hiệu lực")]
        [DefaultValue(1)]
        public int Status { get; set; } = 1;

        // Collection reference property cho khóa ngoại từ Product
        public List<Product> Products { get; set; }
    }
}
