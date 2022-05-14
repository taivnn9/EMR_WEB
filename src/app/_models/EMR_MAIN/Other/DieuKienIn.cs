using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class DieuKienIn
    {
        public int IsByDate { get; set; } // 0 : tat ca, 1 : theo khoang thoi gian
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
