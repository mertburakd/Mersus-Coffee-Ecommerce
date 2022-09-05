using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.DTO
{
    public class ProductAddToCardDto:IDto
    {
        public int cardId { get; set; }
        public int Quantities { get; set; }
    }
}
