using LabTwo.Converters.UniversityConverters;

namespace LabTwo.ViewInteractors.Handlers
{
    public class MainPanelHandler : IPanelHandler
    {
        private Form1 itsMainWindow;

        public MainPanelHandler(Form1 mainWindow)
        {
            itsMainWindow = mainWindow;
        }

        public void AddUniversity()
        {
            itsMainWindow.universityController.AddUniversity(UniversityConverter.ToUniversity(
                itsMainWindow.mainInfoPanelHandler.MainInfoPanelFormStorage.UniversityName,
                itsMainWindow.mainInfoPanelHandler.MainInfoPanelFormStorage.YearOfFoundation
                , itsMainWindow.mainInfoPanelHandler.MainInfoPanelFormStorage.Rank
                , itsMainWindow.departmentsInfoPanelHandler.DepartmentsInfoPanelFormStorage.Departments
                , itsMainWindow.teacherInfoPanelHandler.TeacherInfoPanelFormStorage.Teachers, itsMainWindow.engineerInfoPanelHandler.GetEngineers()
                , itsMainWindow.studentsInfoPanelHandler.GetStudents()
                , itsMainWindow.auditoriumInfoPanelHandler.AuditoriumInfoPanelFormStorage.Auditoriums));
            itsMainWindow.universityComboBox.Items.Add(itsMainWindow.mainInfoPanelHandler.MainInfoPanelFormStorage.UniversityName);
        }
        public void ShowPanel()
        {
            itsMainWindow.mainPanel.Show();
        }
        public void HidePanel()
        {
            //itsMainWindow.mainPanel.Hide();
        }
    }
}
