using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Domain.Common
{
    public class BaseEntity
    {

        public Guid Id { get; set; } = new Guid();

    }
}
