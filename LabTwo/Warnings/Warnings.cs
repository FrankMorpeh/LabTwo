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
}