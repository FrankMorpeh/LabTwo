using LabTwo.Models.Subjects;

namespace LabTwo.ViewInteractors.FormStorages
{
    public class DepartmentsInfoPanelFormStorage
    {
        public string DepartmentName { get; set; }
        public int DeaneryCabinetNumber { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}