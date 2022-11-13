using LabTwo.Controllers.UniversityController;
using LabTwo.Models.Departments;
using LabTwo.Models.Students;
using LabTwo.View;
using LabTwo.ViewInteractors.Handlers;
using LabTwo.Warnings;

namespace LabTwo
{
    public partial class Form1 : Form
    {
        public MainInfoPanelHandler mainInfoPanelHandler;
        public DepartmentsInfoPanelHandler departmentsInfoPanelHandler;
        public UniversityController universityController;
        public UniversityView universityView;
        public List<Department> departments;
        public List<Student> students;
        public Form1()
        {
            InitializeComponent();
            InitializeExtraViewComponents();

            universityController = new UniversityController();
            universityView = new UniversityView(universityController);
            departments = new List<Department>();
            students = new List<Student>();

            universityView.ShowPreviewInfo(universityComboBox);
        }
        private void InitializeExtraViewComponents()
        {
            mainInfoPanelHandler = new MainInfoPanelHandler(this);
            departmentsInfoPanelHandler = new DepartmentsInfoPanelHandler(this);
        }

        private void addUniversityButton_Click(object sender, EventArgs e)
        {
            addUniversityPanel.Show();
        }

        private void mainInfoButton_Click(object sender, EventArgs e)
        {
            mainInfoPanel.Show();
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
            departmentsInfoPanelHandler.AddDepartment();
        }

        private void departmentsButton_Click(object sender, EventArgs e)
        {
            mainInfoPanel.Hide();
            departmentsPanel.Show();
        }
    }
}