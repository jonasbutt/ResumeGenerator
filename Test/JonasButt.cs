using System;
using System.Collections.Generic;
using ResumeGenerator.Model;

namespace ResumeGenerator.Test
{
    public class JonasButt
    {
        static class Constants
        {
            public const string Avanade = "avanade";
            public const string TheCodeArchitect = "thecodearchitect";
            public const string Deloitte = "deloitte";
        }

        public Resume Resume => new Resume
        {
            ProfileSummary = new ProfileSummary
            {
                AboutMe = "",
                //Specialties = {"", ""},
                //ContactMeAbout = {"", ""}
            },
            PersonalInformation = new PersonalInformation
            {
                FullName = "Jonas Butt"
            },
            Experiences = new List<Experience>
            {
                new Experience
                {
                    Id = Constants.Avanade,
                    Name = "Avanade Netherlands",
                    StartDate = new DateTime(2008, 9, 1),
                    Type = ExperienceType.Employment,
                    Link = new Link("http://www.avanade.com")
                },
                new Experience
                {
                    Id = Constants.Deloitte,
                    Name = "Deloitte",
                    StartDate = new DateTime(2007, 2, 1),
                    EndDate = new DateTime(2007, 7, 1),
                    Type = ExperienceType.Internship,
                    Link = new Link("http://www.deloitte.com")
                },
                new Experience
                {
                    Id = Constants.TheCodeArchitect,
                    Name = "The Code Architect",
                    StartDate = new DateTime(2015, 12, 1),
                    Type = ExperienceType.Independent,
                    Link = new Link("http://www.thecodearchitect.com")
                },
                new Experience
                {
                    Name = "Wortell",
                    StartDate = new DateTime(2007, 8, 1),
                    EndDate = new DateTime(2008, 2, 1),
                    Type = ExperienceType.Employment,
                    Link = new Link("http://www.wortell.nl")
                },
                new Experience
                {
                    Name = "Avanade Netherlands",
                    StartDate = new DateTime(2008, 2, 1),
                    EndDate = new DateTime(2008, 7, 1),
                    Type = ExperienceType.Internship,
                    Link = new Link("http://www.avanade.com")
                },
                new Experience
                {
                    Name = "Various college student jobs",
                    Type = ExperienceType.Employment
                },
                new Experience
                {
                    Name = "Various high school student jobs",
                    Type = ExperienceType.Employment
                }
            },
            Publications = new List<Publication>
            {
                new Publication
                {
                    Title = "CodeProject article on Extension Methods",
                    Link = new Link("http://www.codeproject.com/Articles/22909/Using-Extension-Methods-to-Create-Form-Extensions")
                },
                new Publication
                {
                    Title = ".NET Magazine article on Visual Studio 2010",
                    Link = new Link("todo")
                },
                new Publication
                {
                    Title = ".NET Magazine article on Azure AppFabric Caching",
                    Link = new Link("todo")
                },
                new Publication
                {
                    Title = "Automatisering Gids interview",
                    Link = new Link("http://www.automatiseringgids.nl/achtergrond/2008/18/it-talenten-volwassener-dan-gemiddelde-hboer")
                },
                new Publication
                {
                    Title = "Software Factories thesis paper",
                    Link = new Link("todo")
                }
            },
            Awards = new List<Award>
            {
                new Award
                {
                    Name = "",
                    Description = "Transavia project todo",
                    AwardedBy = "Avanade"
                },
                new Award
                {
                    Name = "",
                    Description = "Shell project todo",
                    AwardedBy = "Shell"
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Name = "Loveable CRM",
                    Description = "",
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("")}
                },
                new Project
                {
                    Name = "Incasso-check.nl",
                    Description = "",
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("")}
                },
                new Project
                {
                    Name = "TheCodeArchitect.com",
                    Description = "",
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("http://thecodearchitect.com")}
                },
                new Project
                {
                    Name = "Kentekenchecker",
                    Description = "",
                    Type = ProjectType.Research,
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("")}
                },
                new Project
                {
                    Name = "Cisco AXL API Client Library for .NET",
                    Description = "",
                    Type = ProjectType.OpenSource,
                    StartDate = new DateTime(2015, 6, 1),
                    EndDate = new DateTime(2015, 7, 1),
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("https://github.com/jonasbutt/AXL.NET")}
                },
                new Project
                {
                    Name = "Transavia Flight Offers API Client for .NET ",
                    Description = "",
                    Type = ProjectType.OpenSource,
                    StartDate = new DateTime(2015, 8, 1),
                    EndDate = new DateTime(2015, 9, 1),
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("https://github.com/jonasbutt/Transavia.Api.FlightOffers")}
                },
                new Project
                {
                    Name = "Bitcoin Price Notification App",
                    Description = "",
                    Type = ProjectType.OpenSource,
                    StartDate = new DateTime(2015, 11, 1),
                    EndDate = new DateTime(2015, 12, 1),
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("https://github.com/jonasbutt/BitcoinPriceNotification")}
                },
                new Project
                {
                    Name = "IE History Viewer",
                    Description = "This Windows application displays and exports Internet Explorer browser history.",
                    Type = ProjectType.OpenSource,
                    StartDate = new DateTime(2007, 11, 1),
                    EndDate = new DateTime(2007, 12, 1),
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("https://iehistoryviewer.codeplex.com")}
                },
                new Project
                {
                    Name = "HtmlTextWriter Utility",
                    Description = "Converts HTML, CSS, JavaScript and other types of web content to C# code, mainly for use in the Render method of web parts.",
                    Type = ProjectType.OpenSource,
                    StartDate = new DateTime(2007, 10, 1),
                    EndDate = new DateTime(2007, 11, 1),
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("https://htmltextwriterutil.codeplex.com")}
                },
                new Project
                {
                    Name = "GoF Interpreter C# Example",
                    Description = "This program demonstrates the use a the GoF Interpreter Pattern in a straightforward example.",
                    Type = ProjectType.OpenSource,
                    StartDate = new DateTime(2007, 10, 1),
                    EndDate = new DateTime(2007, 11, 1),
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("https://interpreterexample.codeplex.com")}
                },
                new Project
                {
                    Name = "Design Pattern Finder",
                    Description = "This Windows application can search a source code directory for possible Gang of Four design patterns.",
                    Type = ProjectType.OpenSource,
                    StartDate = new DateTime(2007, 10, 1),
                    EndDate = new DateTime(2007, 11, 1),
                    ExperienceId = Constants.TheCodeArchitect,
                    Links = new List<Link> {new Link("https://designpatternfinder.codeplex.com")}
                },
                new Project
                {
                    Name = "TrackonTrade",
                    Description = "",
                    StartDate = new DateTime(2007, 2, 1),
                    EndDate = new DateTime(2007, 7, 1),
                    ExperienceId = Constants.Deloitte,
                    Links = new List<Link> {new Link("http://www2.deloitte.com/global/en/pages/tax/solutions/trackon-trade-indirect-tax.html")}
                },
                new Project
                {
                    Name = "Transavia API and Integration Platform",
                    Description = "",
                    StartDate = new DateTime(2015, 9, 1),
                    EndDate = null,
                    ExperienceId = Constants.Avanade,
                    Links = new List<Link> {new Link("https://developer.transavia.com")}
                },
                new Project
                {
                    Name = "Transavia Dagtoppers",
                    Description = "",
                    StartDate = new DateTime(2015, 8, 1),
                    EndDate = new DateTime(2015, 10, 1),
                    ExperienceId = Constants.Avanade,
                    Links = new List<Link> {new Link("http://transaviadagtoppers.azurewebsites.net")}
                },
                new Project
                {
                    Name = "Transavia E-commerce Platform",
                    Description = "",
                    StartDate = new DateTime(2014, 8, 1),
                    EndDate = new DateTime(2015, 9, 1),
                    ExperienceId = Constants.Avanade,
                    Links = new List<Link> {new Link("https://www.transavia.com")}
                }
                // TODO School projects
                // TODO Personal projects
                // TODO Avanade + projects + CV avanade

            }
        };
    }
}