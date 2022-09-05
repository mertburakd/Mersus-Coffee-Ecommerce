using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.DTO
{
    public class CardProductDtoModel:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Weight { get; set; }
        public bool? Status { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public string? Image5 { get; set; }
        public decimal Price { get; set; }
        public int Category { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [DataType(DataType.MultilineText)]
        public string? MiniDescription { get; set; }
        public string? MiniImage { get; set; }
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int Piece { get; set; }
    }
}
