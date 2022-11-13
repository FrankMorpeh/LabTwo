namespace LabTwo.Warnings
{
    public interface IWarning
    {
        string Text { get; }
    }
    public class IncorrectUniversityName : IWarning
    {
        public IncorrectUniversityName() { Text = "Name of university must be not empty and contain letters"; }

        public string Text { get; private set; }
    }
    public class IncorrectFoundationYear : IWarning
    {
        public IncorrectFoundationYear() { Text = "Foundation year must be not less than zero"; }

        public string Text { get; private set; }
    }
    public class IncorrectRank : IWarning
    {
        public IncorrectRank() { Text = "Rank must be between 0 and 100"; }

        public string Text { get; private set; }
    }
    public class IncorrectDepartmentName : IWarning
    {
        public IncorrectDepartmentName() { Text = "Name of department must be not empty and contain letters"; }

        public string Text { get; private set; }
    }
    public class IncorrectDeaneryCabinetNumber : IWarning
    {
        public IncorrectDeaneryCabinetNumber() { Text = "Deanery cabinet number must be a positive value"; }

        public string Text { get; private set; }
    }
    public class IncorrectSubjectName : IWarning
    {
        public IncorrectSubjectName() { Text = "Name of subject must be not empty and contain letters"; }

        public string Text { get; private set; }
    }
    public class IncorrectSubjectCredit : IWarning
    {
        public IncorrectSubjectCredit() { Text = "Credit of a subject must be bigger than 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectPersonName : IWarning
    {
        public IncorrectPersonName() { Text = "Person name must not be empty and have numbers"; }

        public string Text { get; private set; }
    }
    public class IncorrectPersonAge : IWarning
    {
        public IncorrectPersonAge() { Text = "Person age must range from 0 to 150"; }

        public string Text { get; private set; }
    }
    public class IncorrectRecordBookNumber : IWarning
    {
        public IncorrectRecordBookNumber() { Text = "Record book number must contain only letters"; }

        public string Text { get; private set; }
    }
    public class IncorrectYearInUniversity : IWarning
    {
        public IncorrectYearInUniversity() { Text = "Year in university must be from 1 to 6"; }

        public string Text { get; private set; }
    }
    public class IncorrectAuditoriumName : IWarning
    {
        public IncorrectAuditoriumName() { Text = "Auditory name must not be empty"; }

        public string Text { get; private set; }
    }
    public class IncorrectCapacity : IWarning
    {
        public IncorrectCapacity() { Text = "Capacity of an auditorium must be bigger than zero"; }

        public string Text { get; private set; }
    }
    public class IncorrectNumberOfRowsInAuditorium : IWarning
    {
        public IncorrectNumberOfRowsInAuditorium() { Text = "Number of rows in an auditorium must not be less than zero"; }

        public string Text { get; private set; }
    }
    public class IncorrectNumberOfDevicesInAuditorium : IWarning
    {
        public IncorrectNumberOfDevicesInAuditorium() { Text = "Number of devices in an auditorium must not be less than zero"; }

        public string Text { get; private set; }
    }
}