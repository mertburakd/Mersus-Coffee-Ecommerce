using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.DTO
{
    public class UserProfileViewModel : IDto
    {
        public List<IGrouping<int,Card>> cards { get; set; }
    }
}
