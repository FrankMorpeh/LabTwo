using LabTwo.Controllers.UniversityController;
using LabTwo.Models.University;
using LabTwo.Models.Workers;

namespace LabTwo.View
{
    public class UniversityView
    {
        private UniversityController itsUniversityController;

        public UniversityView() { itsUniversityController = null; }
        public UniversityView(UniversityController universityController) { itsUniversityController = universityController; }

        public void ShowPreviewInfo(ComboBox comboBox) // shows the name of the uni in the listbox
        {
            foreach (University university in itsUniversityController.Universities)
                comboBox.Items.Add(university.Name);
        }
        public void ShowBasicInfo(ListView listView) // shows Name, Year, and Rank in the listview
        {
            foreach (University university in itsUniversityController.Universities)
                listView.Items.Add(new ListViewItem(new string[] { university.Name, Convert.ToString(university.FoundationYear)
                    , Convert.ToString(university.Rank) }));
            listView.Refresh();
        }
        public void ShowWorkersInfo(ListView listView)
        {
            foreach (University university in itsUniversityController.Universities)
            {
                foreach (Worker worker in university.Workers)
                    listView.Items.Add(new ListViewItem(new string[] { worker.Name, Convert.ToString(worker.Age)
                        , Convert.ToString(worker.Salary) }));
            }
            listView.Refresh();
        }
    }
}