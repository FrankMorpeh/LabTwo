using LabTwo.Validators.UniversityValidators;
using LabTwo.ViewInteractors.FormStorages;
using LabTwo.Warnings;

namespace LabTwo.ViewInteractors.Handlers
{
    public class MainInfoPanelHandler
    {
        private Form1 itsMainWindow;
        private MainInfoPanelFormStorage itsMainInfoPanelFormStorage;

        public MainInfoPanelHandler(Form1 mainWindow)
        {
            itsMainWindow = mainWindow;
            itsMainInfoPanelFormStorage = new MainInfoPanelFormStorage();
        }

        public void ShowMainInfoPanel()
        {
            itsMainWindow.mainInfoPanel.Show();
        }
        public void HideMainInfoPanel()
        {
            itsMainWindow.mainInfoPanel.Hide();
        }
        public void SaveChanges()
        {
            List<IWarning> warnings = UniversityValidator.CheckUniversity(itsMainWindow.universityNameTextBox.Text
                , itsMainWindow.foundationYearTextBox.Text, itsMainWindow.rankTextBox.Text);
            if (warnings.Count == 0)
            {
                itsMainInfoPanelFormStorage.UniversityName = itsMainWindow.universityNameTextBox.Text;
                itsMainInfoPanelFormStorage.YearOfFoundation = itsMainWindow.foundationYearTextBox.Text;
                itsMainInfoPanelFormStorage.Rank = itsMainWindow.rankTextBox.Text;
                BlockSaveChangesButton();
            }
            else
                WarningDisplayer.ShowWarning(itsMainWindow.warningPanel, itsMainWindow.warningTextBox, warnings);
        }
        private void BlockSaveChangesButton()
        {
            itsMainWindow.saveMainInfoButton.Enabled = false;
        }
    }
}