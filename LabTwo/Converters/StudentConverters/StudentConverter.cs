using LabTwo.Models.Students;

namespace LabTwo.Converters.StudentConverters
{
    public static class StudentConverter
    {
        public static Student ToStudent(string name, string age, string recordBookNumber, string yearInUniversity)
        {
            return new Student(name, Convert.ToInt32(age), recordBookNumber, Convert.ToInt32(yearInUniversity));
        }
    }
}