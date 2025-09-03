using static System.Net.Mime.MediaTypeNames;

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
                Description ="This is a group project created in my latest education at Lexicon summmer 2025. It's a fake news site. It uses different API's, It has a payment system, admin pages, and more.",
                MyContribution = "I created the landing page, navigation bars. side bars. I added logic for creating the articles when logged in a Journalist using CRUD operations"
                +"I added API for the market data for Stocks, crypto and more under the economy page. I added backend services for handling websocket connection and retrieving of live data and much more",
                Images = new List<string> {"/images/yesterday/yesterdaynews_banner.png","/images/yesterday/article_crud.png","/images/yesterday/create_article.png","/images/yesterday/markets.png", },
                VideoUrl = "",
                ExternalLink = "https://yesterdaynews.azurewebsites.net/",
                Tags = new List<string> {"C#", "ASP.NET", ".NET Core MVC", "HTML", "CSS", "Javascript", "SQL", "Azure App-services" }
            },
            new Project {
                Id = 2,
                Title = "Another Project",
                Summary = "Summary here",
                Description = "Description here",
                MyContribution = "",
                Images = new List<string> {"/images/project2.png" },
                VideoUrl = "",
                ExternalLink = "",
                Tags = new List<string> { "Python", "Blazor" }
            },
            new Project {
                Id = 3,
                Title = "Glade",
                Summary = "A 3D game created with Unreal Engine. Set in a Swedish forest.",
                Description = "A 3D game created with Unreal Engine. Set in a Swedish forest with trolls, gnomes, mushrooms and a pinecone. My role was that of building the AI and pathfinding for the monsters and player. I also created the UI for the game. It was built in Unreal engine with C++ and blueprints.",
                MyContribution = "",
                Images = new List<string> {"/images/glade/Glade.png", "/images/glade/Glade_menu.png", "/images/glade/Glade_UI.png"  },
                VideoUrl = "https://www.youtube.com/embed/S236AddGh24?enablejsapi=1",
                ExternalLink = "https://game.speldesign.uu.se/projects/3d-games/glade/",
                Tags = new List<string> { "Unreal Engine", "C++", "UI/UX", "Pathfinding", "AI" }
            },
            new Project {
                Id = 4,
                Title = "Flash & Crash",
                Summary = "A 3D game 2 player game with huge controllers. Award winner!",
                Description = "Winner of 'Player choice' at Swedish Game Awards 2014. A 3D game 2 player game with huge controllers, where players compete over an obstacle course.",
                MyContribution = "This was a first year project where I created the level design, puzzle design and the controllers using yoga balls after a lot of prototyping in the workshop.",
                Images = new List<string> { "/images/flash/flash_water.png", "/images/flash/addictive.png", "/images/flash/controller_1.jpg", "/images/flash/dual_screen.png","/images/flash/prototype_1.jpg","/images/flash/prototype_2.jpg" },
                VideoUrl = "https://www.youtube.com/embed/7jRcEtNQDLU?enablejsapi=1",
                ExternalLink = "https://game.speldesign.uu.se/projects/arcade-games/flash-crash/",
                Tags = new List<string> { "Swedish Game Awards","Unity Engine", "C#", "Level design"}
            }
        };
    }
}
