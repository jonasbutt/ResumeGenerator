using System;
using System.Collections.Generic;

namespace ResumeGenerator.Model
{
    public class Project
    {
        public string ExperienceId { get; set; }

        public string Name { get; set; }

        public List<string> Roles { get; set; }

        public List<string> Accomplishments { get; set; }

        public string Description { get; set; }

        public ProjectType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<Link> Links { get; set; }
    }
}