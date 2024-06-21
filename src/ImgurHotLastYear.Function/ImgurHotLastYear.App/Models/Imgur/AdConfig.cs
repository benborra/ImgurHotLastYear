using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models.Imgur;

public class AdConfig
{
    [JsonProperty("safeFlags")]
    public List<string> SafeFlags { get; } = new List<string>();

    [JsonProperty("highRiskFlags")]
    public List<object> HighRiskFlags { get; } = new List<object>();

    [JsonProperty("unsafeFlags")]
    public List<string> UnsafeFlags { get; } = new List<string>();

    [JsonProperty("wallUnsafeFlags")]
    public List<string> WallUnsafeFlags { get; } = new List<string>();

    [JsonProperty("showsAds")]
    public bool ShowsAds { get; set; }

    [JsonProperty("showAdLevel")]
    public int ShowAdLevel { get; set; }

    [JsonProperty("show_ads")]
    public bool ShowAds { get; set; }

    [JsonProperty("nsfw_score")]
    public double NsfwScore { get; set; }
}
