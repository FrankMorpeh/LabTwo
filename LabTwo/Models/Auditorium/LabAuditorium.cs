namespace LabTwo.Models.Auditorium
{
    public class LabAuditorium : Auditorium
    {
        private int itsNumberOfDevices;

        public int NumberOfDevices { get { return itsNumberOfDevices; } set { itsNumberOfDevices = value; } }

        public LabAuditorium()
        {
            itsNumberOfDevices = 0;
        }
        public LabAuditorium(string codeName, int capacity, int numberOfDevices) : base(codeName, capacity)
        {
            itsNumberOfDevices = numberOfDevices;
        }
    }
}