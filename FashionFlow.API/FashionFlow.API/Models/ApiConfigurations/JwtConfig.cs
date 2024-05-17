namespace FashionFlow.API.Models.ApiConfigurations
{
    public class JwtConfig
    {
        public required string SeceretKey { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
    }
}
