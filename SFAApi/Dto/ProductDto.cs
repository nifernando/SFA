using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SFAApi.Dto
{
    public class ProductDto
    {
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
