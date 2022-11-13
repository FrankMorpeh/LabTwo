using LabTwo.Controllers.UniversityController;
using LabTwo.Models.Departments;
using LabTwo.Models.Students;
using LabTwo.Models.Subjects;
using LabTwo.View;
using LabTwo.ViewInteractors.Handlers;
using LabTwo.Warnings;

namespace LabTwo
{
    public partial class Form1 : Form
    {
        public MainInfoPanelHandler mainInfoPanelHandler;
        public DepartmentsInfoPanelHandler departmentsInfoPanelHandler;
        public SubjectsInfoPanelHandler subjectsInfoPanelHandler;
        public UniversityController universityController;
        public UniversityView universityView;
        public Form1()
        {
            InitializeComponent();
            InitializeExtraViewComponents();

            universityController = new UniversityController();
            universityView = new UniversityView(universityController);

            universityView.ShowPreviewInfo(universityComboBox);
        }
        private void InitializeExtraViewComponents()
        {
            mainInfoPanelHandler = new MainInfoPanelHandler(this);
            departmentsInfoPanelHandler = new DepartmentsInfoPanelHandler(this);
            subjectsInfoPanelHandler = new SubjectsInfoPanelHandler(this);
        }

        private void addUniversityButton_Click(object sender, EventArgs e)
        {
            mainInfoPanel.Hide();
            addUniversityPanel.Show();
        }

        private void mainInfoButton_Click(object sender, EventArgs e)
        {
            mainInfoPanelHandler.ShowMainInfoPanel();
        }

        private void okWarningButton_Click(object sender, EventArgs e)
        {
            WarningDisplayer.CloseWarning(warningPanel, warningTextBox);
        }

        private void saveMainInfoButton_Click(object sender, EventArgs e)
        {
            mainInfoPanelHandler.SaveChanges();
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            departmentsInfoPanelHandler.AddDepartment(subjectsInfoPanelHandler.GetTemporarySubjects());
            departmentsInfoPanelHandler.UnblockSubjectAddingButton();
        }

        private void departmentsButton_Click(object sender, EventArgs e)
        {
            mainInfoPanelHandler.HideMainInfoPanel();
            departmentsInfoPanelHandler.ShowDepartmentsPanel();
        }

        private void addStudentsButton_Click(object sender, EventArgs e)
        {
            departmentsInfoPanelHandler.HideDepartmentsPanel();
            subjectsInfoPanelHandler.ShowSubjectsPanel();
        }
        
        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            subjectsInfoPanelHandler.AddSubject();
        }

        private void saveSubjectsButton_Click(object sender, EventArgs e)
        {
            subjectsInfoPanelHandler.HideSubjectsPanel();
            departmentsInfoPanelHandler.ShowDepartmentsPanel();
            departmentsInfoPanelHandler.BlockSubjectAddingButton();
        }
    }
}