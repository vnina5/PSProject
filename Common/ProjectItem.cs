using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class ProjectItem
    {
        public Project Project { get; set; }
        public int SerialNumber { get; set; }
        public Activity Activity { get; set; }
    }
}
