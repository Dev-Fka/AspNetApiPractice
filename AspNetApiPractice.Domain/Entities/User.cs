using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Domain.Entities
{
    public class User:IdentityUser
    {
        public DateTime BirthDay { get; set; }

    }
}
