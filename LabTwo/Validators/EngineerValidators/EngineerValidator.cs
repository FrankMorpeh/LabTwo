using LabTwo.Warnings;

namespace LabTwo.Validators.EngineerValidators
{
    public static class EngineerValidator
    {
        public static List<IWarning> CheckEngineer(string name, string age, string salary, string engineerClass)
        {
            List<IWarning> warnings = new List<IWarning>();
            if (CommonValidator.PersonNameIsValid(name) == false)
                warnings.Add(new IncorrectPersonName());
            if (CommonValidator.PersonAgeIsValid(age) == false)
                warnings.Add(new IncorrectPersonAge());
            if (CommonValidator.WorkerSalaryIsValid(salary) == false)
                warnings.Add(new IncorrectSalary());
            if (CommonValidator.NameIsEmpty(engineerClass))
                warnings.Add(new IncorrectScientificTitle());
            return warnings;
        }
    }
}