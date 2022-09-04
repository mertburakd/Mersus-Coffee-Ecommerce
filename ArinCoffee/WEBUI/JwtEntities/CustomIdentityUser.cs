using Entities.Models.DTO;
using Microsoft.AspNetCore.Identity;
using WEBUI.Models;

namespace WEBUI.JwtEntities
{
    public class CustomIdentityUser:IdentityUser<int>
    {
        public string IpAdress { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public static implicit operator UserDetailViewModel(CustomIdentityUser user)
        {
            return new UserDetailViewModel
            {
                IpAdress = user.IpAdress,
                Address = user.Address,
                Country = user.Country,
                City = user.City,

            };
        }
    }
}
