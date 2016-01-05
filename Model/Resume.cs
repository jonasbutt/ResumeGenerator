using System.Collections.Generic;

namespace ResumeGenerator.Model
{
    public class Resume
    {
        public ProfileSummary ProfileSummary { get; set; }

        public PersonalInformation PersonalInformation { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public List<Education> Education { get; set; } 

        public List<Experience> Experiences { get; set; }

        public List<Publication> Publications { get; set; }

        public List<Skill> Skills { get; set; }

        public List<Interest> Interests { get; set; }

        public List<Language> Languages { get; set; }

        public List<Project> Projects { get; set; }

        public List<Award> Awards { get; set; }

        public List<Download> Downloads { get; set; }

        public List<Certification> Certifications { get; set; }

        public List<Training> Training { get; set; }
    }
}