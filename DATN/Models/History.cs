using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models
{
    public class History
    {
        public int Id { get; set; }

        public int Account_Id { get; set; }

        public Account Account { get; set; }

        public int Invoice_Id { get; set; }

        public Invoice Invoice { get; set; }

        //[DisplayName("Còn hoạt động")]
        //[DefaultValue(true)]
        public int Status { get; set; } = 1;

    }
}
