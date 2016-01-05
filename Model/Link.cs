using System;

namespace ResumeGenerator.Model
{
    public class Link
    {
        public Uri Url { get; set; }

        public string Description { get; set; }

        public Link(string url, string description = null)
        {
            //this.Url = new Uri(url);
            this.Description = description;
        }
    }
}