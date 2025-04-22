using System.Text.Json.Serialization;

namespace FreeUsePuller.Models
{
    public class CategoryListing
    {
        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;
        [JsonIgnore]
        public string Name {
            get
            {
                var splitName = this.URL.Split('/').Last();
                return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(splitName.Replace('-', ' '));
            }
        }
    }
}