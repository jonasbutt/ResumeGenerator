namespace ResumeGenerator.Model
{
    public class Resume
    {
        public PersonalInformation PersonalInformation { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public Publications Publications { get; set; }

        public Experiences Experiences { get; set; }
    }
}