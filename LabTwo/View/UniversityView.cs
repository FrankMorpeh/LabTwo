using LabTwo.Controllers.UniversityController;
using LabTwo.Models.Auditoriums;
using LabTwo.Models.Departments;
using LabTwo.Models.Students;
using LabTwo.Models.Subjects;
using LabTwo.Models.University;
using LabTwo.Models.Workers;
using LabTwo.Models.Workers.Engineers;
using LabTwo.Models.Workers.Teachers;

namespace LabTwo.View
{
    public class UniversityView
    {
        private UniversityController itsUniversityController;

        public UniversityView() { itsUniversityController = null; }
        public UniversityView(UniversityController universityController) { itsUniversityController = universityController; }


        /*
            Displaying info
        */
        public void ShowPreviewInfo(ComboBox comboBox) // shows the names of the unis in the combobox
        {
            foreach (University university in itsUniversityController.Universities)
                comboBox.Items.Add(university.Name);
        }
        public void ShowBasicInfo(int index, Label label) // shows Name, Year, and Rank in the label
        {
            label.Text = string.Empty;
            label.Text += "Name: " + itsUniversityController[index].Name + "\r\n";
            label.Text += "Foundation year: " + itsUniversityController[index].FoundationYear + "\r\n";
            label.Text += "Rank: " + itsUniversityController[index].Rank + "\r\n";
        }
        public void ShowWorkersInfo(int index, ListView listView)
        {
            SetWorkerColumns(listView);

            foreach (Worker worker in itsUniversityController[index].Workers)
                listView.Items.Add(new ListViewItem(new string[] { worker.Name, Convert.ToString(worker.Age)
                        , Convert.ToString(worker.Salary) }));

            listView.Refresh();
        }
        public void ShowTeachersInfo(int index, ListView listView)
        {
            SetWorkerColumns(listView);
            listView.Columns.Add("Scientific title");

            foreach (Teacher teacher in itsUniversityController[index].Workers.OfType<Teacher>())
            {
                listView.Items.Add(new ListViewItem(new string[] { teacher.Name, Convert.ToString(teacher.Age)
                        , Convert.ToString(teacher.Salary), teacher.ScientificTitle.ToString() }));
            }

            listView.Refresh();
        }
        public void ShowStudentsInfo(int index, ListView listView)
        {
            FormStudentsListView(listView, itsUniversityController[index].Students);
        }
        public void ShowStudentsOfTeacherInfo(int index, int teacherIndex, ListView listView)
        {
            FormStudentsListView(listView, itsUniversityController[index].Workers.OfType<Teacher>().ToList()[teacherIndex].Students);
        }
        private void FormStudentsListView(ListView listView, List<Student> students)
        {
            SetPersonColumns(listView);
            listView.Columns.Add("Record book");
            listView.Columns.Add("Year in university");

            foreach (Student student in students)
                listView.Items.Add(new ListViewItem(new string[] { student.Name, Convert.ToString(student.Age)
                    , student.RecordBookNumber, Convert.ToString(student.YearInUniversity) }));

            listView.Refresh();
        }
        public void ShowEngineersInfo(int index, ListView listView)
        {
            SetWorkerColumns(listView);
            listView.Columns.Add("Engineer class");

            foreach (Engineer engineer in itsUniversityController[index].Workers.OfType<Engineer>())
            {
                listView.Items.Add(new ListViewItem(new string[] { engineer.Name, Convert.ToString(engineer.Age)
                    , Convert.ToString(engineer.Salary), engineer.EngineerClass.ToString() }));
            }

            listView.Refresh();
        }
        public void ShowDepartmentsInfo(int index, ListView listView)
        {
            ShowDepartmentsInfo(itsUniversityController[index].Departments, listView);
        }
        public static void ShowDepartmentsInfo(List<Department> departments, ListView listView)
        {
            foreach (Department department in departments)
                listView.Items.Add(new ListViewItem(new string[] { department.Name
                    , Convert.ToString(department.DeaneryCabinetNumber) }));

            listView.Refresh();
        }
        public void ShowSubjectsInfo(int index, int depIndex, ListView listView)
        {
            ShowSubjectsInfo(itsUniversityController[index].Departments[depIndex].Subjects, listView);
        }
        public static void ShowSubjectsInfo(List<Subject> subjects, ListView listView)
        {
            foreach (Subject subject in subjects)
                listView.Items.Add(new ListViewItem(new string[] { subject.Name, Convert.ToString(subject.Credit) }));

            listView.Refresh();
        }
        public void ShowAuditoriumsInfo(int index, ListView listView)
        {
            listView.Columns.Add("Auditorium type");
            listView.Columns.Add("Code name");
            listView.Columns.Add("Capacity");
            listView.Columns.Add("Engineers");

            foreach (Auditorium auditorium in itsUniversityController[index].Auditoriums)
                listView.Items.Add(new ListViewItem(new string[] { auditorium.GetType().Name, auditorium.CodeName
                , Convert.ToString(auditorium.Capacity), auditorium.NamesOfEngineers }));

            listView.Refresh();
        }


        /*
            Helping private methods
        */
        private void SetPersonColumns(ListView listView)
        {
            listView.Columns.Add("Name");
            listView.Columns.Add("Age");
        }
        private void SetWorkerColumns(ListView listView)
        {
            SetPersonColumns(listView);
            listView.Columns.Add("Salary");
        }
    }
}