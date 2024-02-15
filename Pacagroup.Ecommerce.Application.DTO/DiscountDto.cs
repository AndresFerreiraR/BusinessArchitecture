
namespace Pacagroup.Ecommerce.Application.DTO
{
    using Pacagroup.Ecommerce.Application.DTO.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public record DiscountDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Percent { get; set; }
        public DiscountStatusDto Status { get; set; }
    }
}
