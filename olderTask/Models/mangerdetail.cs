using olderTask.Models.ControlUesrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace olderTask.Models
{
    public class mangerdetail
    {
        
        public int id { get; set; }
        public int name { get; set; }
        public int email { get; set; }
        
        public virtual Order Order { get; set; }
        public virtual painds Painds { get; set; }
    }
}
