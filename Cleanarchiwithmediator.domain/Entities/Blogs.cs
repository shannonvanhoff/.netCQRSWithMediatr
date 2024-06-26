using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarchiwithmediator.domain.Entities
{
    public class Blogs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string author { get; set; }
    }
    
}
