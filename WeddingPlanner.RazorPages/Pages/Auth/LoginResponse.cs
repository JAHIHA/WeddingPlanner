namespace WeddingPlanner.RazorPages.Pages.Auth
{
    public class LoginResponse
    {// Login response where we take the token and the expiration date
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }

}
