using LabTwo.Models.Workers.Engineers;

namespace LabTwo.Converters.WorkerConverters
{
    public static class EngineerConverter
    {
        public static Engineer ToEngineer(string name, string age, string salary, string engineerClass)
        {
            return new Engineer(name, Convert.ToInt32(age), Convert.ToDouble(salary), ToEngineerClass(engineerClass));
        }
        private static EngineerClass ToEngineerClass(string engineerClass)
        {
            if (engineerClass == "Third")
                return EngineerClass.Third;
            else if (engineerClass == "Second")
                return EngineerClass.Second;
            else
                return EngineerClass.First;
        }
    }
}