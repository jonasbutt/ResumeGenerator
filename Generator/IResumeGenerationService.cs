using ResumeGenerator.Model;

namespace ResumeGenerator.Generator
{
    public interface IResumeGenerationService
    {
        string GenerateResumeHtml(Resume resume, string templatePath);
    }
}