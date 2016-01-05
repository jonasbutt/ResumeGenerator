using System;

namespace ResumeGenerator.Model
{
    public class PersonalInformation
    {
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
    }
}