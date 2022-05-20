using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MAU.HttpCliente.App.Models
{
  public class Data
  {
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("num_comments")]
    public int? NumComments { get; set; }

    [JsonPropertyName("story_id")]
    public object StoryId { get; set; }

    [JsonPropertyName("story_title")]
    public string StoryTitle { get; set; }

    [JsonPropertyName("story_url")]
    public string StoryUrl { get; set; }

    [JsonPropertyName("parent_id")]
    public int? ParentId { get; set; }

    [JsonPropertyName("created_at")]
    public int CreatedAt { get; set; }
  }

  public class JsonRoot
  {
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("per_page")]
    public int PerPage { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("data")]
    public List<Data> Data { get; set; }
  }
}
