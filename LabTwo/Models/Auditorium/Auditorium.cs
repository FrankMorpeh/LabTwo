using LabTwo.Models.Workers.Engineers;

namespace LabTwo.Models.Auditorium
{
    public abstract class Auditorium
    {
        protected string itsCodeName;
        protected int itsCapacity;
        protected List<Engineer> itsEngineers;

        public string CodeName { get { return itsCodeName; } set { itsCodeName = value; } }
        public int Capacity { get { return itsCapacity; } set { itsCapacity = value; } }

        public Auditorium()
        {
            itsCodeName = string.Empty;
            itsCapacity = 0;
            itsEngineers = null;
        }
        public Auditorium(string name, int capacity, List<Engineer> engineers)
        {
            itsCodeName = name;
            itsCapacity = capacity;
            itsEngineers = engineers;
        }

        public bool AddEngineer(Engineer engineer) 
        {
            if (itsEngineers.Count + 1 > 2) // there can be no more than two engineers for one auditorium
                return false;
            else
            {
                itsEngineers.Add(engineer);
                return true;
            }
        }
        public void RemoveEngineer(Engineer engineer) { itsEngineers.Remove(engineer); }
    }
}