namespace LabTwo.Models.Workers.Engineers
{
    public class Engineer : Worker
    {
        private EngineerClass itsEngineerClass;
        
        public EngineerClass EngineerClass { get { return itsEngineerClass; } set { itsEngineerClass = value; } }

        public Engineer()
        {
            itsEngineerClass = EngineerClass.Third;
        }
        public Engineer(string name, int age, double salary, EngineerClass engineerClass) : base(name, age, salary)
        {
            itsEngineerClass = engineerClass;
        }
    }
}