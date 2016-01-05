using System;

namespace ResumeGenerator.Model
{
    public class Publication
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Publisher { get; set; }

        public Link Link { get; set; }
    }
}