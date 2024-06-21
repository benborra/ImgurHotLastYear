using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models.Imgur;

public class Tag
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("display_name")]
    public string DisplayName { get; set; }

    [JsonProperty("followers")]
    public int Followers { get; set; }

    [JsonProperty("total_items")]
    public int TotalItems { get; set; }

    [JsonProperty("following")]
    public bool Following { get; set; }

    [JsonProperty("is_whitelisted")]
    public bool IsWhitelisted { get; set; }

    [JsonProperty("background_hash")]
    public string BackgroundHash { get; set; }

    [JsonProperty("thumbnail_hash")]
    public object ThumbnailHash { get; set; }

    [JsonProperty("accent")]
    public string Accent { get; set; }

    [JsonProperty("background_is_animated")]
    public bool BackgroundIsAnimated { get; set; }

    [JsonProperty("thumbnail_is_animated")]
    public bool ThumbnailIsAnimated { get; set; }

    [JsonProperty("is_promoted")]
    public bool IsPromoted { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("logo_hash")]
    public object LogoHash { get; set; }

    [JsonProperty("logo_destination_url")]
    public object LogoDestinationUrl { get; set; }

    [JsonProperty("description_annotations")]
    public DescriptionAnnotations DescriptionAnnotations { get; set; }
}
