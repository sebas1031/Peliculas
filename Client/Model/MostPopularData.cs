using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoviesProy.Client.Model
{



    public class MostPopularData
    {
        public List<MostPopularDataDetail> Items { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class MostPopularDataDetail
    {
        
        public string Id { get; set; }
        public string Rank { get; set; }
        public string RankUpDown { get; set; }
        public string Title { set; get; }
        public string FullTitle { set; get; }
        public string Year { set; get; }
        public string Image { get; set; }
        public string Crew { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingCount { get; set; }
    }
}