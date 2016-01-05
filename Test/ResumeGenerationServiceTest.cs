using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPdfGenerator;
using ResumeGenerator.Generator;

namespace ResumeGenerator.Test
{
    [TestClass]
    public class ResumeGenerationServiceTest
    {
        [TestMethod]
        public void CanGenerateResumeHtml()
        {
            // Arrange
            var resumeGenerationService = new ResumeGenerationService(new HtmlGenerator());
            var resume = new JonasButt().Resume;
            var currentPath = Directory.GetCurrentDirectory();
            var templatePath = Path.Combine(currentPath, "ResumeTemplate.cshtml");

            // Act
            var resumeHtml = resumeGenerationService.GenerateResumeHtml(resume, templatePath);

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(resumeHtml));
        }
    }
}