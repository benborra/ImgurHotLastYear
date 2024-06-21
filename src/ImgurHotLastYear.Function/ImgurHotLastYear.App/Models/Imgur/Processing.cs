using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models.Imgur;

public class Processing
{
    [JsonProperty("status")]
    public string Status { get; set; }
}
