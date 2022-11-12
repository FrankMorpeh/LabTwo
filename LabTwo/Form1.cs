using LabTwo.Controllers.UniversityController;
using LabTwo.View;

namespace LabTwo
{
    public partial class Form1 : Form
    {
        public UniversityController universityController;
        public UniversityView universityView;
        public List<Panel> panels;
        public Form1()
        {
            InitializeComponent();
            universityController = new UniversityController();
            universityView = new UniversityView(universityController);

            universityView.ShowPreviewInfo(universityComboBox);
        }

        private void addUniversityButton_Click(object sender, EventArgs e)
        {
            addUniversityPanel.Show();
        }
    }
}