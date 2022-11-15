using LabTwo.Converters.WorkerConverters;
using LabTwo.Validators.EngineerValidators;
using LabTwo.View;
using LabTwo.ViewInteractors.FormStorages;
using LabTwo.Warnings;

namespace LabTwo.ViewInteractors.Handlers
{
    public class EngineerInfoPanelHandler : IPanelHandler
    {
        private Form1 itsMainWindow;
        private EngineerInfoPanelFormStorage itsEngineerInfoPanelFormStorage;

        public EngineerInfoPanelHandler(Form1 mainWindow)
        {
            itsMainWindow = mainWindow;
            itsEngineerInfoPanelFormStorage = new EngineerInfoPanelFormStorage();
            AddColumnsToListView();
            AddVariantsToListBox();
        }
        private void AddColumnsToListView()
        {
            itsMainWindow.engineerListView.Columns.Add("Name");
            itsMainWindow.engineerListView.Columns.Add("Age");
            itsMainWindow.engineerListView.Columns.Add("Salary");
            itsMainWindow.engineerListView.Columns.Add("Engineer class");
        }
        private void AddVariantsToListBox()
        {
            itsMainWindow.engineerClassComboBox.Items.Add("First");
            itsMainWindow.engineerClassComboBox.Items.Add("Second");
            itsMainWindow.engineerClassComboBox.Items.Add("Third");
        }

        public void ShowPanel()
        {
            itsMainWindow.engineerPanel.Show();
            UniversityView.ShowEngineersInfo(itsEngineerInfoPanelFormStorage.Engineers, itsMainWindow.engineerListView);
        }
        public void HidePanel()
        {
            itsMainWindow.engineerPanel.Hide();
        }
        public void AddEngineer()
        {
            List<IWarning> warnings = EngineerValidator.CheckEngineer(itsMainWindow.engineerNameTextBox.Text, itsMainWindow.engineerAgeTextBox.Text
                , itsMainWindow.engineerSalaryTextBox.Text, ((string)itsMainWindow.engineerClassComboBox.SelectedItem));
            if (warnings.Count == 0)
            {
                itsEngineerInfoPanelFormStorage.Engineers.Add(EngineerConverter.ToEngineer(itsMainWindow.engineerNameTextBox.Text
                    , itsMainWindow.engineerAgeTextBox.Text, itsMainWindow.engineerSalaryTextBox.Text
                    , ((string)itsMainWindow.engineerClassComboBox.SelectedItem)));
                UniversityView.ShowEngineersInfo(itsEngineerInfoPanelFormStorage.Engineers, itsMainWindow.engineerListView);
            }
            else
                WarningDisplayer.ShowWarning(itsMainWindow.warningPanel, itsMainWindow.warningTextBox, warnings);
        }
    }
}