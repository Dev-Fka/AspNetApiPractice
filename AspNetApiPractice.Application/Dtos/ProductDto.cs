using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Domain.Dtos
{
    public class ProductDto
    {

        public string? ProductName{ get; set; }
        public double ProductValue{ get; set; }
        public DateTime PurchaseDate{ get; set; }
    }
}
