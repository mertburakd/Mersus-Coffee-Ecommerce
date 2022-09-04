using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBUI.JwtEntities
{
    public class CustomIdentityRole : IdentityRole<int>
    {
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
