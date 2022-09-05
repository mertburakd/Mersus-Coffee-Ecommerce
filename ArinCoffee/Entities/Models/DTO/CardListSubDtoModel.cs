using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.DTO
{
    public class CardListSubDtoModel
    {
        public List<CardProductDtoModel> CategoryProduct { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
