using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models;

public class Image
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public object Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("datetime")]
    public int Datetime { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("animated")]
    public bool Animated { get; set; }

    [JsonProperty("width")]
    public int Width { get; set; }

    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("size")]
    public int Size { get; set; }

    [JsonProperty("views")]
    public int Views { get; set; }

    [JsonProperty("bandwidth")]
    public object Bandwidth { get; set; }

    [JsonProperty("vote")]
    public object Vote { get; set; }

    [JsonProperty("favorite")]
    public bool Favorite { get; set; }

    [JsonProperty("nsfw")]
    public object Nsfw { get; set; }

    [JsonProperty("section")]
    public object Section { get; set; }

    [JsonProperty("account_url")]
    public object AccountUrl { get; set; }

    [JsonProperty("account_id")]
    public object AccountId { get; set; }

    [JsonProperty("is_ad")]
    public bool IsAd { get; set; }

    [JsonProperty("in_most_viral")]
    public bool InMostViral { get; set; }

    [JsonProperty("has_sound")]
    public bool HasSound { get; set; }

    [JsonProperty("tags")]
    public List<object> Tags { get; } = new List<object>();

    [JsonProperty("ad_type")]
    public int AdType { get; set; }

    [JsonProperty("ad_url")]
    public string AdUrl { get; set; }

    [JsonProperty("edited")]
    public string Edited { get; set; }

    [JsonProperty("in_gallery")]
    public bool InGallery { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("mp4_size")]
    public int Mp4Size { get; set; }

    [JsonProperty("mp4")]
    public string Mp4 { get; set; }

    [JsonProperty("gifv")]
    public string Gifv { get; set; }

    [JsonProperty("hls")]
    public string Hls { get; set; }

    [JsonProperty("processing")]
    public Processing Processing { get; set; }

    [JsonProperty("comment_count")]
    public object CommentCount { get; set; }

    [JsonProperty("favorite_count")]
    public object FavoriteCount { get; set; }

    [JsonProperty("ups")]
    public object Ups { get; set; }

    [JsonProperty("downs")]
    public object Downs { get; set; }

    [JsonProperty("points")]
    public object Points { get; set; }

    [JsonProperty("score")]
    public object Score { get; set; }

    [JsonProperty("looping")]
    public bool? Looping { get; set; }
}
