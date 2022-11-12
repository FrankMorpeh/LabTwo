using LabTwo.Models.Students;
using LabTwo.Models.Workers;
using LabTwo.Models.Auditoriums;

namespace LabTwo.Models.University
{
    public class University : IEqualityComparer<University>
    {
        private string itsName;
        private int itsFoundationYear;
        private double itsRank;
        private List<Worker> itsWorkers;
        private List<Student> itsStudents;
        private List<Auditorium> itsAuditoriums;

        public string Name { get { return itsName; } set { itsName = value; } }
        public int FoundationYear { get { return itsFoundationYear; } set { itsFoundationYear = value; } }
        public double Rank { get { return itsRank; } set { itsRank = value; } }
        public List<Worker> Workers { get { return itsWorkers; } set { itsWorkers = value; } }
        public List<Student> Students { get { return itsStudents; } set { itsStudents = value; } }
        public List<Auditorium> Auditoriums { get { return itsAuditoriums; } set { itsAuditoriums = value; } }


        public University()
        {
            itsName = string.Empty;
            itsFoundationYear = 0;
            itsRank = 0;
            itsWorkers = null;
            itsStudents = null;
            itsAuditoriums = null;
        }
        public University(string name, int foundationYear, double rank, List<Worker> workers, List<Student> students
            , List<Auditorium> auditoriums)
        {
            itsName = name;
            itsFoundationYear = foundationYear;
            itsRank = rank;
            itsWorkers = workers;
            itsStudents = students;
            itsAuditoriums = auditoriums;
        }
        public University(University rhs)
        {
            itsName = rhs.itsName;
            itsFoundationYear = rhs.itsFoundationYear;
            itsRank = rhs.itsRank;
            itsWorkers = rhs.itsWorkers;
            itsStudents = rhs.itsStudents;
            itsAuditoriums = rhs.itsAuditoriums;
        }

        
        /*
            Data handling 
        */

        // Workers 
        public void AddWorker(Worker worker) { itsWorkers.Add(worker); }
        public void RemoveWorkerAt(int index) { itsWorkers.RemoveAt(index); }

        // Students
        public void AddStudent(Student student) { itsStudents.Add(student); }
        public void RemoveStudentAt(int index) { itsStudents.RemoveAt(index); }
        
        // Auditoriums
        public void AddAuditorium(Auditorium auditorium) { itsAuditoriums.Add(auditorium); }
        public void RemoveAuditoriumAt(int index) { itsAuditoriums.RemoveAt(index); }


        /* 
            IEqualityComparer
        */
        public bool Equals(University lhs, University rhs)
        {
            return lhs.itsName == rhs.itsName && lhs.itsFoundationYear == rhs.itsFoundationYear && lhs.itsRank == rhs.itsRank
                && lhs.itsWorkers.Equals(rhs.itsWorkers) && lhs.itsStudents.Equals(rhs.itsStudents)
                && lhs.itsAuditoriums.Equals(rhs.itsAuditoriums);
        }
        public int GetHashCode(University university)
        {
            return university.itsName.GetHashCode() + university.itsFoundationYear.GetHashCode() - university.itsRank.GetHashCode();
        }
    }
}