using Newtonsoft.Json;

namespace Um45.Models.Rest
{
    public class SearchResults
    {
        [JsonProperty(PropertyName = "total_count")]
        public int TotalCount { get; set; }

        [JsonProperty(PropertyName = "incomplete_results")]
        public bool IncompleteResults { get; set; }

        [JsonProperty(PropertyName = "items")]
        public Item[] Items { get; set; }
    }
}