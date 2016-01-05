using System;

namespace ResumeGenerator.Model
{
    public class Award
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string AwardedBy { get; set; }
    }
}