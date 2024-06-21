using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models;

public class Processing
{
    [JsonProperty("status")]
    public string Status { get; set; }
}
