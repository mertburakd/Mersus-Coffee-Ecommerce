using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.DTO
{
    public class AdressViewModel:IDto
    {
        public Adress adress { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
