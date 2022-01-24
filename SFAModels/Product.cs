using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAModels
{
    public class Product: BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
