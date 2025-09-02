namespace Portfolio.Data
{
    public static class ProjectData
    {
        public static List<Project> Projects = new List<Project>
        {
            new Project {
                Id = 1,
                Title = "Yesterday's News",
                Summary = "A fake news site. It uses different API's, It has a payment system, admin pages, and more.",
                Description ="Fill in this",
                ImageUrl = "/images/yesterdaynews_banner.png",
                ExternalLink = "https://yesterdaynews.azurewebsites.net/",
                Tags = new List<string> {"C#", "ASP.NET", ".NET Core MVC", "HTML", "CSS", "Javascript", "SQL", "Azure App-services" }
            },
            new Project {
                Id = 2,
                Title = "Another Project",
                Summary = "Summary here",
                Description = "Description here",
                ImageUrl = "/images/project2.png",
                ExternalLink = "",
                Tags = new List<string> { "Python", "Blazor" }
            }
        };
    }
}
