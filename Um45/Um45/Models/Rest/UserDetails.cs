using System;
using Newtonsoft.Json;

namespace Um45.Models.Rest
{

    public class UserDetails
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty(PropertyName = "gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty(PropertyName = "followers_url")]
        public string FollowersUrl { get; set; }

        [JsonProperty(PropertyName = "following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty(PropertyName = "gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty(PropertyName = "starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty(PropertyName = "subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonProperty(PropertyName = "organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonProperty(PropertyName = "repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty(PropertyName = "events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty(PropertyName = "received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        [JsonProperty(PropertyName = "blog")]
        public string Blog { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "email")]
        public object Email { get; set; }

        [JsonProperty(PropertyName = "hireable")]
        public object Hireable { get; set; }

        [JsonProperty(PropertyName = "bio")]
        public object Bio { get; set; }

        [JsonProperty(PropertyName = "public_repos")]
        public int PublicRepos { get; set; }

        [JsonProperty(PropertyName = "public_gists")]
        public int PublicGists { get; set; }

        [JsonProperty(PropertyName = "followers")]
        public int Followers { get; set; }

        [JsonProperty(PropertyName = "following")]
        public int Following { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }

    }

}
