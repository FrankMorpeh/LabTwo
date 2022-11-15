using LabTwo.Converters.WorkerConverters;
using LabTwo.Models.Students;
using LabTwo.Validators.TeacherValidators;
using LabTwo.View;
using LabTwo.ViewInteractors.FormStorages;
using LabTwo.Warnings;

namespace LabTwo.ViewInteractors.Handlers
{
    public class TeacherInfoPanelHandler : IPanelHandler
    {
        private Form1 itsMainWindow;
        private TeacherInfoPanelFormStorage itsTeacherInfoPanelFormStorage;
        private List<Student> itsStudentsOfTeacher;

        public TeacherInfoPanelHandler(Form1 mainWindow)
        {
            itsMainWindow = mainWindow;
            itsTeacherInfoPanelFormStorage = new TeacherInfoPanelFormStorage();
            AddColumnsToListView();
        }
        private void AddColumnsToListView()
        {
            itsMainWindow.studentsOfTeacherListView.Columns.Add("Name");
            itsMainWindow.studentsOfTeacherListView.Columns.Add("Age");
            itsMainWindow.studentsOfTeacherListView.Columns.Add("Salary");
        }

        public void OnAddStudents(List<Student> students) // called from StudentsOfTeacherInfoPanelHandler
        {
            itsStudentsOfTeacher = students;
            itsMainWindow.addStudentToTeacherButton.Enabled = false;
        }
        public void AddTeacher()
        {
            List<IWarning> warnings = TeacherValidator.CheckTeacher(itsMainWindow.teacherNameTextBox.Text, itsMainWindow.teacherAgeTextBox.Text
                , itsMainWindow.teacherSalaryTextBox.Text);
            if (warnings.Count == 0)
            {
                itsTeacherInfoPanelFormStorage.Teachers.Add(TeacherConverter.ToTeacher(itsMainWindow.teacherNameTextBox.Text
                    , itsMainWindow.teacherAgeTextBox.Text, itsMainWindow.teacherSalaryTextBox.Text, itsStudentsOfTeacher));
                UniversityView.ShowTeachersInfo(itsTeacherInfoPanelFormStorage.Teachers, itsMainWindow.teachersListView);
                itsMainWindow.addStudentToTeacherButton.Enabled = true;
            }
            else
                WarningDisplayer.ShowWarning(itsMainWindow.warningPanel, itsMainWindow.warningTextBox, warnings);
        }
        public void ShowPanel()
        {
            itsMainWindow.teachersPanel.Show();
        }
        public void HidePanel()
        {
            itsMainWindow.teachersPanel.Hide();
        }
    }
}