using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Um45.Models;

namespace Um45.ViewModels.MockData
{
    public static class HomePageData
    {
        private static Random random;
        public static ObservableCollection<GitHubGuy> Items { get; set; }

        public static GitHubGuy GetRandomGitHubGuy()
        {
            //var output = Newtonsoft.Json.JsonConvert.SerializeObject(Monkeys);
            return Items[random.Next(0, Items.Count)];
        }

        static HomePageData()
        {
            random = new Random();
            Items = new ObservableCollection<GitHubGuy>
            {
                new GitHubGuy
                {
                    Name = "cewing",
                    Avatar = "https://avatars1.githubusercontent.com/u/417109?v=3"
                },
                new GitHubGuy
                {
                    Name = "crismanNoble",
                    Avatar = "https://avatars2.githubusercontent.com/u/1040884?v=3"
                },
                new GitHubGuy
                {
                    Name = "zelzel2315",
                    Avatar = "https://avatars0.githubusercontent.com/u/7561680?v=3"
                },
                new GitHubGuy
                {
                    Name = "qrz-io",
                    Avatar = "https://avatars0.githubusercontent.com/u/3646206?v=3"
                },
                new GitHubGuy
                {
                    Name = "xyxabcdiy",
                    Avatar = "https://avatars3.githubusercontent.com/u/12330423?v=3"
                },
                new GitHubGuy
                {
                    Name = "hudokkow",
                    Avatar = "https://avatars1.githubusercontent.com/u/516183?v=3"
                }
            };

        }
    }
}
