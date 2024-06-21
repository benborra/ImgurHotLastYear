using ImgurHotLastYear.App.Models.App;
using ImgurHotLastYear.App.Models.Imgur;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace ImgurHotLastYear.App;

public class Runner : IRunner
{
    public ImgurConfig Configuration { get; }

    public Runner(IOptions<ImgurConfig> configuration)
    {
        Configuration = configuration.Value;
    }

    public async Task FetchAndPostAsync()
    {
        // Create an instance of HttpClient
        using var client = CreateClient();
        Datum mostUpvotedPost = await GetAllFromTodayLastYearAsync(client);

        // Display the most upvoted post information
        Console.WriteLine($"Title: {mostUpvotedPost.Title}");
        Console.WriteLine($"Upvotes: {mostUpvotedPost.Ups}");
        Console.WriteLine($"Link: {mostUpvotedPost.Link}");
    }

    private static async Task<Datum> GetAllFromTodayLastYearAsync(HttpClient client)
    {
        var lastYear = DateTime.Today.AddYears(-1);

        var startingPage = GetTheStartingPageAsync(client, lastYear);


        throw new NotImplementedException();

        await Task.CompletedTask;
    }

    private static async Task<int> GetTheStartingPageAsync(HttpClient client, DateTime lastYear)
    {
        // Find the first post of last year
        var firstPage = 300;
        var startFound = false;

        while (!startFound)
        {
            var posts = await FrontPagePaginatedAsync(client, firstPage);
            posts = posts.OrderByDescending(p => lastYear).ToList();

            if (posts.First().PostedAt < lastYear && posts.Last().PostedAt >= lastYear)
            {
                return firstPage;
            }
            firstPage--;
        }

        throw new Exception($"Couldn't find the first post of the day {lastYear}.");
    }

    private static async Task<List<Datum>> FrontPagePaginatedAsync(HttpClient client, int page)
    {
        var result = await TryGetAsync<PostData>(client, $"gallery/hot/viral/day/{page}?mature=true");

        if (result is null || !result.Data.Any())
        {
            throw new Exception("No post found, result is null :(");
        }

        // Get the post with the most upvotes
        return result.Data;
    }

    private HttpClient CreateClient()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://api.imgur.com/3/");
        // Set Imgur API request headers
        client.DefaultRequestHeaders.Add("Authorization", $"Client-ID {"the id"}");

        return client;
    }

    private static async Task<T> TryGetAsync<T>(HttpClient client, string url) where T : class
    {
        var response = client.GetAsync(url);

        return await TryParseAsync<T>(response);
    }

    private static async Task<T> TryParseAsync<T>(Task<HttpResponseMessage?> responseTask)
    {
        var response = await responseTask;

        // Check if the request was successful
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Failed to fetch data. StatusCode: {response.StatusCode}");
        }

        // Read the response content as a string
        string responseBody = await response.Content.ReadAsStringAsync();

        // Deserialize the JSON response
        var result = JsonConvert.DeserializeObject<T>(responseBody);

        return result;
    }
}

public interface IRunner
{
    Task FetchAndPostAsync();
}
