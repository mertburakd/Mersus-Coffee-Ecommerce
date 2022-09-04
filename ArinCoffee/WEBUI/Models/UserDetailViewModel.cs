using WEBUI.JwtEntities;

namespace WEBUI.Models
{
    public class UserDetailViewModel
    {
        public string IpAdress { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public static implicit operator CustomIdentityUser(UserDetailViewModel userDetail)
        {
            return new CustomIdentityUser
            {
                IpAdress = userDetail.IpAdress,
                Address = userDetail.Address,
                Country = userDetail.Country,
                City = userDetail.City,
                
            };
        }
    }
}
