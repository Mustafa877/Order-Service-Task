using olderTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace olderTask.Models
{
    public class OrderDetail
    {
       
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int SubjectId { get; set; }
        public int Amount { get; set; }
        public string subject { get; set; }
        public decimal Price { get; set; }
        public virtual Subject Subjects { get; set; }
        public virtual Order Order { get; set; }
    }
}
