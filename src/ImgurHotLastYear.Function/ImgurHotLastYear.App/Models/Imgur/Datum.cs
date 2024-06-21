using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models.Imgur;

public class Datum
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public object Description { get; set; }

    [JsonProperty("datetime")]
    public int Datetime { get; set; }
    public DateTime PostedAt => DateTimeOffset.FromUnixTimeSeconds(Datetime).DateTime;


    [JsonProperty("cover")]
    public string Cover { get; set; }

    [JsonProperty("cover_width")]
    public int CoverWidth { get; set; }

    [JsonProperty("cover_height")]
    public int CoverHeight { get; set; }

    [JsonProperty("account_url")]
    public string AccountUrl { get; set; }

    [JsonProperty("account_id")]
    public int AccountId { get; set; }

    [JsonProperty("privacy")]
    public string Privacy { get; set; }

    [JsonProperty("layout")]
    public string Layout { get; set; }

    [JsonProperty("views")]
    public int Views { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("ups")]
    public int Ups { get; set; }

    [JsonProperty("downs")]
    public int Downs { get; set; }

    [JsonProperty("points")]
    public int Points { get; set; }

    [JsonProperty("score")]
    public int Score { get; set; }

    [JsonProperty("is_album")]
    public bool IsAlbum { get; set; }

    [JsonProperty("vote")]
    public object Vote { get; set; }

    [JsonProperty("favorite")]
    public bool Favorite { get; set; }

    [JsonProperty("nsfw")]
    public bool Nsfw { get; set; }

    [JsonProperty("section")]
    public string Section { get; set; }

    [JsonProperty("comment_count")]
    public int CommentCount { get; set; }

    [JsonProperty("favorite_count")]
    public int FavoriteCount { get; set; }

    [JsonProperty("topic")]
    public object Topic { get; set; }

    [JsonProperty("topic_id")]
    public object TopicId { get; set; }

    [JsonProperty("images_count")]
    public int ImagesCount { get; set; }

    [JsonProperty("in_gallery")]
    public bool InGallery { get; set; }

    [JsonProperty("is_ad")]
    public bool IsAd { get; set; }

    [JsonProperty("tags")]
    public List<Tag> Tags { get; } = new List<Tag>();

    [JsonProperty("ad_type")]
    public int AdType { get; set; }

    [JsonProperty("ad_url")]
    public string AdUrl { get; set; }

    [JsonProperty("in_most_viral")]
    public bool InMostViral { get; set; }

    [JsonProperty("include_album_ads")]
    public bool IncludeAlbumAds { get; set; }

    [JsonProperty("images")]
    public List<Image> Images { get; } = new List<Image>();

    [JsonProperty("ad_config")]
    public AdConfig AdConfig { get; set; }
}
