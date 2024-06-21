using Newtonsoft.Json;

namespace ImgurHotLastYear.App.Models;

public class PostData
{
    [JsonProperty("data")]
    public List<Datum> Data { get; } = new List<Datum>();

    [JsonProperty("success")]
    public bool Success { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }
}
