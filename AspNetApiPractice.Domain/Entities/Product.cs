using AspNetApiPractice.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Domain.Entities
{
    public  class Product: BaseEntity
    {

        public string ProductName { get; set; } = null!;

        public double ProductValue { get; set; }
    }
}
