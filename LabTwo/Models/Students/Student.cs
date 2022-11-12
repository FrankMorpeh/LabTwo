﻿using LabTwo.Models.People;

namespace LabTwo.Models.Students
{
    public class Student : Person
    {
        private string itsRecordBookNumber;
        private int itsYearInUniversity;

        public string RecordBookNumber { get { return itsRecordBookNumber; } set { itsRecordBookNumber = value; } }
        public int YearInUniversity { get { return itsYearInUniversity; } set { itsYearInUniversity = value; } }
        
        public Student()
        {
            itsRecordBookNumber = string.Empty;
            itsYearInUniversity = 0;
        }
        public Student(string name, int age, string recordBookNumber, int yearInUniversity) : base(name, age)
        {
            itsRecordBookNumber = recordBookNumber;
            itsYearInUniversity = yearInUniversity;
        }
    }
}