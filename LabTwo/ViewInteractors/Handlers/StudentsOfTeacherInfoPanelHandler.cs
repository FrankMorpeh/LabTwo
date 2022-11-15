using LabTwo.Models.Students;
using LabTwo.View;

namespace LabTwo.ViewInteractors.Handlers
{
    public class StudentsOfTeacherInfoPanelHandler : IPanelHandler
    {
        private Form1 itsMainWindow;
        private event Action<List<Student>> itsStudentsForTeacherChosenEvent;

        public StudentsOfTeacherInfoPanelHandler(Form1 mainWindow, TeacherInfoPanelHandler teacherInfoPanelHandler)
        {
            itsMainWindow = mainWindow;
            itsStudentsForTeacherChosenEvent += teacherInfoPanelHandler.OnAddStudents;
        }

        public void ShowPanel()
        {
            itsMainWindow.studentsOfTeacherPanel.Show();
            UniversityView.ShowStudentsInfo(itsMainWindow.studentsInfoPanelHandler.GetStudents(), itsMainWindow.studentsOfTeacherListView);
        }
        public void HidePanel()
        {
            itsMainWindow.studentsOfTeacherPanel.Hide();
        }

        public void ChooseStudentsForTeacher(List<Student> students)
        {
            itsStudentsForTeacherChosenEvent(students);
        }
    }
}