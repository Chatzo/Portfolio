namespace Portfolio.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string MyContribution { get; set; }
        public List<string> Images { get; set; }
        public string VideoUrl { get; set; }
        public string ExternalLink { get; set; }
        public List<string> Tags { get; set; }
    }
}
