using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugManagerUI.Models;

namespace BugManagerUI.Interface
{
    public interface IUtility
    {
        string InsertProject(Project project);
        string Token();
        void callAPI(string token);
        List<Dashboard> GetDashboard(string token);
        string createUserStory(string usname, string priority, string points, string description, string comments, string projectid, string token);
        string createDefect(string DefectName, string priority, string UserStoryNumber, string description, string comments, string usid, string token);
        string createProject(string orgName, string projectsize, string projname, string token);

        string saveUS(string usname, string usstatus, string UserStoryNumber, string description, string token);
        string saveDefect(string DefectName, string defno, string defstatus, string description, string token);
    }
}
