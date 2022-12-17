using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Domain.Entities
{
    public class Users:IdentityUser
    {
        public Guid UserId{ get; set; }
        public string? FullName { get; set; }

    }
}
