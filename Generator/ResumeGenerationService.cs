using RazorPdfGenerator;
using ResumeGenerator.Model;

namespace ResumeGenerator.Generator
{
    public class ResumeGenerationService : IResumeGenerationService
    {
        private readonly IHtmlGenerator htmlGenerator;

        public ResumeGenerationService(IHtmlGenerator htmlGenerator)
        {
            this.htmlGenerator = htmlGenerator;
        }

        public string GenerateResumeHtml(Resume resume, string templatePath)
        {
            return this.htmlGenerator.GenerateHtml(templatePath, resume);
        }
    }
}