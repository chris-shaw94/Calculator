using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Object
{
    public class SimpleObject
    {
        public string Name { get; set; }

        public SimpleObject()
        {
            // this is just generating a new unique id for this object
            Name = Guid.NewGuid().ToString();
        }
    }
}
