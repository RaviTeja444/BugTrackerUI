using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagerUI.Models
{
    public class UserStory
    {
        public string UserStoryName { get; set; }
        public string Priority { get; set; }
        public string Points { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
    }
}
