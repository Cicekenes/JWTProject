namespace JWTProject.Core.Configuration
{
    public class Client
    {
        public string Id { get; set; }
        public string Secret { get; set; }
        //www.myap1.com
        public List<string> Audiences { get; set; } //Api'lerden hangilere erişim sağlayacak?
    }
}
