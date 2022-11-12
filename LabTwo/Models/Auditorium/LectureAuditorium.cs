namespace LabTwo.Models.Auditorium
{
    public class LectureAuditorium : Auditorium
    {
        private int itsNumberOfRows;

        public int NumberOfRows { get { return itsNumberOfRows; } set { itsNumberOfRows = value; } }

        public LectureAuditorium(string codeName, int capacity, int numberOfRows) : base(codeName, capacity)
        {
            itsNumberOfRows = numberOfRows;
        }
    }
}