using LabTwo.ViewInteractors.FormStorages;
using LabTwo.Validators.DepartmentValidators;
using LabTwo.Warnings;
using LabTwo.Models.Subjects;
using LabTwo.Converters.DepartmentConverters;
using LabTwo.Warnings;

namespace LabTwo.ViewInteractors.Handlers
{
    public class DepartmentsInfoPanelHandler
    {
        private Form1 itsMainWindow;
        DepartmentsInfoPanelFormStorage itsDepartmentsInfoPanelFormStorage;

        public DepartmentsInfoPanelHandler(Form1 mainWindow)
        {
            itsMainWindow = mainWindow;
            itsDepartmentsInfoPanelFormStorage = new DepartmentsInfoPanelFormStorage();
        }

        /*
            TODO: add real lists
        */
        public void AddDepartment()
        {
            if (AddDepartmentToList() == true)
                UpdateDepartmentListView();
        }
        private bool AddDepartmentToList()
        {
            List<IWarning> warnings = DepartmentValidator.CheckDepartment(itsMainWindow.departmentNameTextBox.Text
                , itsMainWindow.deaneryCabinetNumberTextBox.Text, new List<string>(), new List<string>());
            if (warnings.Count == 0)
            {
                itsMainWindow.departments.Add(DepartmentConverter.ToDepartment(itsMainWindow.departmentNameTextBox.Text
                    , itsMainWindow.deaneryCabinetNumberTextBox.Text, new List<Subject>()));
                return true;
            }
            else
            {
                WarningDisplayer.ShowWarning(itsMainWindow.warningPanel, itsMainWindow.warningTextBox, warnings);
                return false;
            }
        }
        private void UpdateDepartmentListView()
        {
            if (itsMainWindow.universityController.Count > 0)
                itsMainWindow.universityView.ShowDepartmentInfo(itsMainWindow.universityController.Count - 1, itsMainWindow.departmentsListView);
            else
                itsMainWindow.universityView.ShowDepartmentInfo(itsMainWindow.universityController.Count, itsMainWindow.departmentsListView);
        }
    }
}