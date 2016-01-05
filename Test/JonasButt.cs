using ResumeGenerator.Model;

namespace ResumeGenerator.Test
{
    public class JonasButt
    {
        public Resume Resume => new Resume
        {
            PersonalInformation = new PersonalInformation
            {
                FullName = "Jonas Butt"
            },
            Publications = new Publications
            {
                new Publication
                {
                    Title = "My Publication"
                }
            }
        };
    }
}