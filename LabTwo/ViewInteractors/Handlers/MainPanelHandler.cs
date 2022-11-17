﻿using LabTwo.Converters.UniversityConverters;

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
            SetValuesToNull();
        }
        public void ShowPanel()
        {
            itsMainWindow.mainPanel.Show();
        }
        public void HidePanel()
        {
            //itsMainWindow.mainPanel.Hide();
        }

        private void SetValuesToNull()
        {
            itsMainWindow.universityNameTextBox.Text = string.Empty;
            itsMainWindow.foundationYearTextBox.Text = string.Empty;
            itsMainWindow.rankTextBox.Text = string.Empty;
            itsMainWindow.saveMainInfoButton.Enabled = true;
            itsMainWindow.mainInfoPanelHandler = new MainInfoPanelHandler(itsMainWindow);

            itsMainWindow.departmentNameTextBox.Text = string.Empty;
            itsMainWindow.deaneryCabinetNumberTextBox.Text = string.Empty;
            itsMainWindow.departmentNameTextBox.Text = string.Empty;
            itsMainWindow.departmentsInfoPanelHandler = new DepartmentsInfoPanelHandler(itsMainWindow);
            itsMainWindow.departmentsListView.Columns.Clear();
            itsMainWindow.departmentsListView.Items.Clear();

            itsMainWindow.studentNameTextBox.Text = string.Empty;
            itsMainWindow.studentAgeTextBox.Text = string.Empty;
            itsMainWindow.studentRecordBookTextBox.Text = string.Empty;
            itsMainWindow.studentYearInUniversityTextBox.Text = string.Empty;
            itsMainWindow.studentsInfoPanelHandler = new StudentsInfoPanelHandler(itsMainWindow);
            itsMainWindow.studentsListView.Columns.Clear();
            itsMainWindow.studentsListView.Items.Clear();

            itsMainWindow.teacherNameTextBox.Text = string.Empty;
            itsMainWindow.teacherAgeTextBox.Text = string.Empty;
            itsMainWindow.teacherSalaryTextBox.Text = string.Empty;
            itsMainWindow.teacherInfoPanelHandler = new TeacherInfoPanelHandler(itsMainWindow);
            itsMainWindow.teachersListView.Items.Clear();
            itsMainWindow.teachersListView.Columns.Clear();

            itsMainWindow.studentsOfTeacherInfoPanelHandler = new StudentsOfTeacherInfoPanelHandler(itsMainWindow, itsMainWindow.teacherInfoPanelHandler);
            itsMainWindow.studentsOfTeacherListView.Columns.Clear();
            itsMainWindow.studentsOfTeacherListView.Items.Clear();

            itsMainWindow.engineerNameTextBox.Text = string.Empty;
            itsMainWindow.engineerAgeTextBox.Text = string.Empty;
            itsMainWindow.engineerSalaryTextBox.Text = string.Empty;
            itsMainWindow.engineerClassComboBox.SelectedIndex = -1;
            itsMainWindow.engineerInfoPanelHandler = new EngineerInfoPanelHandler(itsMainWindow);
            itsMainWindow.engineerListView.Items.Clear();
            itsMainWindow.engineerListView.Columns.Clear();

            itsMainWindow.auditoriumTypeComboBox.SelectedIndex = -1;
            itsMainWindow.auditoriumCodeNameTextBox.Text = string.Empty;
            itsMainWindow.auditoriumNumberOfRowsOrDevicesTextBox.Text = string.Empty;
            itsMainWindow.auditoriumsListView.Items.Clear();
            itsMainWindow.auditoriumsListView.Columns.Clear();
            itsMainWindow.auditoriumInfoPanelHandler = new AuditoriumInfoPanelHandler(itsMainWindow);

            itsMainWindow.engineersOfAuditoriumInfoPanelHandler = new EngineersOfAuditoriumInfoPanelHandler(itsMainWindow
                , itsMainWindow.auditoriumInfoPanelHandler);
            itsMainWindow.engineersOfAuditoriumListView.Columns.Clear();
            itsMainWindow.engineersOfAuditoriumListView.Items.Clear();
        }
    }
}