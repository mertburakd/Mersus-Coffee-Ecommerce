using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.DTO
{
    public class AllOrderDto:IDto
    {
        public int Id { get; set; }
        public List<Card> card { get; set; }
    }
}
