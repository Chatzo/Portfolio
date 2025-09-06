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
                Images = new List<string> {"/images/yesterday/yesterday_banner2.png","/images/yesterday/article_crud.png","/images/yesterday/create_article.png","/images/yesterday/markets.png", },
                VideoUrl = "",
                ExternalLink = "https://yesterdaynews.azurewebsites.net/",
                Tags = new List<string> {"C#", "ASP.NET", ".NET Core MVC", "HTML", "CSS","Bootstrap" ,"Javascript", "SQL", "Azure App-services", "Azure-functions" }
            },
            new Project {
                Id = 2,
                Title = "Gamma Movies",
                Summary = "A fake movie webshop using .NET Core",
                Description = "This is a 1-2 week school project. It uses .Net Core and CRUD operations. No logic added for payments and only fake log in use 'admin@admin.se' and 'password' if you want to try it.",
                MyContribution = "I added some CRUD operations as well as the shopping cart / check out logic and general code for the website.",
                Images = new List<string> {"/images/gammamovies/gmovies_1.png","/images/gammamovies/gmovies_2.png","/images/gammamovies/gmovies_3.png" },
                VideoUrl = "",
                ExternalLink = "https://gamma-movies.azurewebsites.net/",
                Tags = new List<string> { "C#", "ASP.NET", ".NET Core MVC", "HTML", "CSS", "Bootstrap", "Javascript", "SQL", }
            },
            new Project {
                Id = 3,
                Title = "Glade",
                Summary = "A 3D game created with Unreal Engine. Set in a Swedish magical forest.",
                Description = "A 3D game created with Unreal Engine. Set in a Swedish magical forest with trolls, gnomes, mushrooms and a pinecone.",
                MyContribution = "My role was that of building the AI and pathfinding for the monsters and player. I also created the UI for the game and some other game logic. It was built in Unreal engine with C++ and blueprints.",
                Images = new List<string> {"/images/glade/Glade.png", "/images/glade/Glade_menu.png", "/images/glade/Glade_UI.png"  },
                VideoUrl = "https://www.youtube.com/embed/S236AddGh24?enablejsapi=1",
                ExternalLink = "https://game.speldesign.uu.se/projects/3d-games/glade/",
                Tags = new List<string> { "Unreal Engine", "C++", "UI/UX", "Pathfinding", "AI" }
            },
            new Project {
                Id = 4,
                Title = "Flash & Crash",
                Summary = "A 3D game for 2 players with huge controllers. Award winner!",
                Description = "Winner of 'Player choice' at Swedish Game Awards 2014. A 3D game for 2 players with huge controllers, where players compete over an obstacle course. Extremely fun! The game was also showcased at Dreamhack and the Technical Museum in Stockholm",
                MyContribution = "This was a first year project where I created the level design, puzzle design and the controllers using yoga balls after a lot of prototyping in the workshop.",
                Images = new List<string> { "/images/flash/flash_water.png", "/images/flash/addictive.png", "/images/flash/controller_1.jpg", "/images/flash/dual_screen.png","/images/flash/prototype_1.jpg","/images/flash/prototype_2.jpg" },
                VideoUrl = "https://www.youtube.com/embed/7jRcEtNQDLU?enablejsapi=1",
                ExternalLink = "https://game.speldesign.uu.se/projects/arcade-games/flash-crash/",
                Tags = new List<string> { "Swedish Game Awards","Unity Engine", "C#", "Level design"}
            },
            new Project {
                Id = 5,
                Title = "Trollbunden",
                Summary = "A difficult 2D puzzle game with an oldschool feel to it.",
                Description = "A hobby game project that I worked on myself. its a difficult 2D puzzle game with an oldschool feel to it. The player controls dual characters a troll and a gnome(tomte) connected to eachother by the gnomes beard",
                MyContribution = "I created everything myself except some of the placeholder art. The game is currently not finished and missing art, sound/music and a lot of levels but it has 10 playable levels",
                Images = new List<string> { "/images/trollbunden/level4.png","/images/trollbunden/level3.png","/images/trollbunden/level2.png","/images/trollbunden/troll.png","/images/trollbunden/tomte.jpg" },
                VideoUrl = "",
                ExternalLink = "",
                Tags = new List<string> { "Unity Engine", "C#", "2D Art", "2D Animation", "Game Design","Level design", "Puzzle design" }
            },
             new Project {
                Id = 6,
                Title = "Hempbased",
                Summary = "A 2D top down shooter game for the blockchain market",
                Description = "A start-up project for the blockchain market. A 2D game built to spread knowlegde use of industry hemp (Cancelled by the owners)",
                MyContribution = "For the 4 months I worked with HempBased I was in charge of coding the AI and general game logic´.",
                Images = new List<string> { "/images/hempbased/hemp.png", "/images/hempbased/hemp_2.png", "/images/hempbased/hemp_3.png" },
                VideoUrl = "",
                ExternalLink = "",
                Tags = new List<string> {"Unity", "C#", "2D Game", "Blockchain"}
            },
            new Project {
                Id = 7,
                Title = "Sorting Algorithms",
                Summary = "A collection of sorting algorithms built with test driven development",
                Description = "A collection of sorting algorithms built with test driven development with xUnit",
                MyContribution = "I created a binary heap for the heap search. I also created my own called HashBucketSort based on the idea of bucket sort but using dictionaries in a hash-like structure.",
                Images = new List<string> {"/images/sorting/heap.png","/images/sorting/insertion.png"},
                VideoUrl = "https://www.youtube.com/embed/NTkvghRfZJI?enablejsapi=1",
                ExternalLink = "https://github.com/Chatzo/Sorting",
                Tags = new List<string> {"C#", "Sorting algorithms", "Data structures", "xUnit", "Test driven development"}
            }
        };
    }
}