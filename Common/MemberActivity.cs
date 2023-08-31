using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class MemberActivity
    {
        public Member Member { get; set; }
        public Activity Activity { get; set; }
        public int NumOfComplited { get; set; }
        public DateTime Date { get; set; }
    }
}
