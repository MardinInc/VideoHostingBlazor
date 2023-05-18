namespace VideoHosting.Data
{
    public class Video
    {
        public string Title = "";
        public string Description = "";
        public string Url = "";

        public Video(string Title, string Description, string Url) 
        {
            this.Title = Title;
            this.Description = Description;
            this.Url = Url;
        }
    }
}
