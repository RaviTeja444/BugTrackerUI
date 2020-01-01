using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagerUI.Models
{
    public class Dashboard
    {
        public int projectname { get; set; }
        public int projectdescription { get; set; }
        public int userstoryname { get; set; }
        public int userstorydescription { get; set; }
        public int userstorynumber { get; set; }
        public int defectname { get; set; }
        public int defectnumber { get; set; }
        public int defectdescription { get; set; }
    }
}
