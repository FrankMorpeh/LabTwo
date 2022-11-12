﻿namespace LabTwo.Models.Subjects
{
    public class Subject
    {
        private string itsName;
        private double itsCredit;

        public string Name { get { return itsName; } set { itsName = value; } }
        public double Credit { get { return itsCredit; } set { itsCredit = value; } }

        public Subject()
        {
            itsName = string.Empty;
            itsCredit = 0.0;
        }
        public Subject(string name, double credit)
        {
            itsName = name;
            itsCredit = credit;
        }
    }
}