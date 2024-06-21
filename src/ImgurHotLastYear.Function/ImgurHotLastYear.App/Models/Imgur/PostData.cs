using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models.Imgur;

public class PostData
{
    [JsonProperty("data")]
    public List<Datum> Data { get; } = new List<Datum>();

    [JsonProperty("success")]
    public bool Success { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }
}
