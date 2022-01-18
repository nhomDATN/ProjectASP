using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class Promotion
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Value { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime EndDay { get; set; }

        public int Product_Id { get; set; }

        [ForeignKey("Product_Id")]
        public Product Product { get; set; }

        //[DisplayName("Còn hiệu lực")]
        //[DefaultValue(1)]
        public int Status { get; set; } = 1;
    }
}
