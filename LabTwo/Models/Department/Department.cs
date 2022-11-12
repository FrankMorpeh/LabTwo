using LabTwo.Models.Groups;
using LabTwo.Models.Subjects;

namespace LabTwo.Models.Department
{
    public class Department
    {
        private string itsDepartmentName;
        private List<Subject> itsSubjects;
        private List<Group> itsGroups;

        public string Name { get { return itsDepartmentName; } set { itsDepartmentName = value; } }
        public List<Subject> Subjects { get { return itsSubjects; } set { itsSubjects = value; } }
        public List<Group> Groups { get { return itsGroups; } set { itsGroups = value; } }

        public Department()
        {
            itsDepartmentName = string.Empty;
            itsSubjects = null;
            itsGroups = null;
        }
        public Department(string departmentName, List<Subject> subjects, List<Group> groups)
        {
            itsDepartmentName = departmentName;
            itsSubjects = subjects;
            itsGroups = groups;
        }
    }
}