using LabTwo.Controllers;
using LabTwo.Controllers.UniversityController;
using LabTwo.Converters.StudentConverters;
using LabTwo.View;
using LabTwo.ViewInteractors.Handlers;
using LabTwo.Warnings;
using static System.Windows.Forms.ListView;

namespace LabTwo
{
    public partial class Form1 : Form
    {
        public MainInfoPanelHandler mainInfoPanelHandler;
        public DepartmentsInfoPanelHandler departmentsInfoPanelHandler;
        public SubjectsInfoPanelHandler subjectsInfoPanelHandler;
        public StudentsInfoPanelHandler studentsInfoPanelHandler;
        public TeacherInfoPanelHandler teacherInfoPanelHandler;
        public StudentsOfTeacherInfoPanelHandler studentsOfTeacherInfoPanelHandler;
        public PanelController panelController;
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
            studentsInfoPanelHandler = new StudentsInfoPanelHandler(this);
            teacherInfoPanelHandler = new TeacherInfoPanelHandler(this);
            studentsOfTeacherInfoPanelHandler = new StudentsOfTeacherInfoPanelHandler(this, teacherInfoPanelHandler);
            panelController = new PanelController(this);
        }

        private void addUniversityButton_Click(object sender, EventArgs e)
        {
            mainInfoPanel.Hide();
            addUniversityPanel.Show();
        }

        private void mainInfoButton_Click(object sender, EventArgs e)
        {
            panelController.ShowPanel(mainInfoPanelHandler);
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
            panelController.ShowPanel(departmentsInfoPanelHandler);
        }

        private void addSubjectsButton_Click(object sender, EventArgs e)
        {
            panelController.ShowPanel(subjectsInfoPanelHandler);
        }
        
        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            subjectsInfoPanelHandler.AddSubject();
        }

        private void saveSubjectsButton_Click(object sender, EventArgs e)
        {
            panelController.ShowPanel(departmentsInfoPanelHandler);
            departmentsInfoPanelHandler.BlockSubjectAddingButton();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            studentsInfoPanelHandler.AddStudent();
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            panelController.ShowPanel(studentsInfoPanelHandler);
        }

        private void chooseStudentsOfTeacherButton_Click(object sender, EventArgs e)
        {
            studentsOfTeacherInfoPanelHandler.ChooseStudentsForTeacher(StudentConverter.ToStudentList(studentsInfoPanelHandler.GetStudents()
                , studentsOfTeacherListView.SelectedIndices));
            panelController.ShowPanel(teacherInfoPanelHandler);
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            teacherInfoPanelHandler.AddTeacher();
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            panelController.ShowPanel(teacherInfoPanelHandler);
        }

        private void addStudentToTeacherButton_Click(object sender, EventArgs e)
        {
            panelController.ShowPanel(studentsOfTeacherInfoPanelHandler);
        }
    }
}