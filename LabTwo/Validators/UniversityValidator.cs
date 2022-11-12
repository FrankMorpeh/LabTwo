using LabTwo.Warnings;

namespace LabTwo.Validators
{
    delegate void StringConversionDelegate(string value, ref bool isValid);
    public static class UniversityValidator
    {
        public static List<IWarning> CheckUniversity(string name, string foundationYear, string rank)
        {
            List<IWarning> warnings = new List<IWarning>();
            if (NameIsValid(name) == false)
                warnings.Add(new IncorrectUniversityName());
            else if (FoundationYearIsValid(foundationYear) == false)
                warnings.Add(new IncorrectFoundationYear());
            else if (RankIsValid(rank) == false)
                warnings.Add(new IncorrectRank());
            return warnings;
        }
        private static bool NameIsValid(string name)
        {
            return name != string.Empty && name.Any(s => Char.IsLetter(s));
        }
        private static bool MakeStringConversionCheck(string value, StringConversionDelegate stringConversionDelegate)
        {
            bool isValid = true;
            try
            {
                stringConversionDelegate(value, ref isValid);
            }
            catch (Exception)
            {
                isValid = false;
            }
            return isValid;
        }
        private static bool FoundationYearIsValid(string strFoundationYear)
        {
            return MakeStringConversionCheck(strFoundationYear, ConvertAndCheckFoundationYear);
        }
        private static bool RankIsValid(string strRank)
        {
            return MakeStringConversionCheck(strRank, ConvertAndCheckRank);
        }
        private static void ConvertAndCheckFoundationYear(string strFoundationYear, ref bool isValid)
        {
            int foundationYear = Convert.ToInt32(strFoundationYear);
            if (foundationYear < 0)
                isValid = false;
        }
        private static void ConvertAndCheckRank(string strRank, ref bool isValid)
        {
            double rank = Convert.ToDouble(strRank);
            if (rank < 0 || rank > 100)
                isValid = false;
        }
    }
}