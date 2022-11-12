using LabTwo.Models.Subjects;
using LabTwo.Warnings;

namespace LabTwo.Validators
{
    public static class DepartmentValidator
    {
        public static List<IWarning> CheckDepartment(string name, string deaneryCabinetNumber, List<string> subjectNames
            , List<string> subjectCredits)
        {
            List<IWarning> warnings = new List<IWarning>();
            if (CommonValidator.UniversityNameIsValid(name) == false)
                warnings.Add(new IncorrectDepartmentName());
            if (IsDeaneryCabinetNumberValid(deaneryCabinetNumber) == false)
                warnings.Add(new IncorrectDeaneryCabinetNumber());
            warnings.AddRange(SubjectsValidator.CheckSubjects(subjectNames, subjectCredits));
            return warnings;
        }
        private static bool IsDeaneryCabinetNumberValid(string deaneryCabinetNumber)
        {
            return CommonValidator.MakeStringConversionCheck(deaneryCabinetNumber, ConvertAndCheckDeaneryCabinetNumber);
        }
        private static void ConvertAndCheckDeaneryCabinetNumber(string strDeaneryCabinetNumber, ref bool isValid)
        {
            int deaneryCabinetNumber = Convert.ToInt32(strDeaneryCabinetNumber);
            if (deaneryCabinetNumber < 0)
                isValid = false;
        }
    }
}