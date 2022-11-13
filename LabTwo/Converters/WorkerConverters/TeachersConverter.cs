using LabTwo.Models.Students;
using LabTwo.Models.Workers.Teachers;

namespace LabTwo.Converters.WorkerConverters
{
    public static class TeachersConverter
    {
        public static Teacher ToTeacher(string name, string age, string salary, string scientificTitle, List<Student> students)
        {
            return new Teacher(name, Convert.ToInt32(age), Convert.ToDouble(salary), ToScientificTitle(scientificTitle), students);
        }
        private static ScientificTitle ToScientificTitle(string scientificTitle)
        {
            if (scientificTitle == "Usual teacher")
                return ScientificTitle.UsualTeacher;
            else if (scientificTitle == "Associate professor")
                return ScientificTitle.AssociateProfessor;
            else
                return ScientificTitle.Professor;
        }
    }
}