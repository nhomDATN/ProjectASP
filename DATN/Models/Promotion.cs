using System;
using System.Collections.Generic;
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

        public List<Product> Products { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }

        //[DisplayName("Còn hiệu lực")]
        //[DefaultValue(1)]
        public int Status { get; set; } = 1;
    }
}
