using System.Collections.Generic;

namespace MoviesProy.Client.Model
{
    
    public class TitleData
    {
        public string Id { get; set; }
        public string Title { set; get; }
        public string OriginalTitle { get; set; }
        public string FullTitle { set; get; }
        public string Year { set; get; }
        public string ReleaseDate { set; get; }
        public string RuntimeMins { set; get; }
        public string RuntimeStr { set; get; }
        public string Plot { set; get; } // IMDb Plot allways en, TMDb Plot translate
        public string PlotLocal { set; get; }
        public bool PlotLocalIsRtl { set; get; }
        public string Awards { set; get; }
        public string Image { get; set; }
        public string Type { set; get; }
        public string Directors { set; get; }
        public List<StarShort> DirectorList { get; set; }
        public string Writers { set; get; }
        public List<StarShort> WriterList { get; set; }
        public string Stars { set; get; }
        public List<StarShort> StarList { get; set; }
        public string Genres { set; get; }
        public string Companies { get; set; }
        public List<CompanyShort> CompanyList { get; set; }
        public string ContentRating { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingVotes { get; set; }
        public string MetacriticRating { set; get; }
        public TrailerData Trailer { get; set; }
        public BoxOfficeShort BoxOffice { get; set; }
        public string Tagline { get; set; }
        public string Keywords { get; set; }
        public List<string> KeywordList { get; set; }
        public List<SimilarShort> Similars { get; set; }
        public string ErrorMessage { get; set; }
    }
 
    public class PosterDataItem
    {
        public string Id { get; set; }
        public string Link { get; set; }
        public double AspectRatio { get; set; }
        public string Language { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
 
 
    public class SimilarShort
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
 
    public class StarShort
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
 
    public class BoxOfficeShort
    {
        public string Budget { get; set; }
        public string OpeningWeekendUSA { get; set; }
        public string GrossUSA { get; set; }
        public string CumulativeWorldwideGross { get; set; }
    }
 
    public class CompanyShort
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class TrailerData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public string VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoDescription { get; set; }
        public string ThumbnailUrl { get; set; }
        public string UploadDate { get; set; }
        public string Link { get; set; }
        public string LinkEmbed { get; set; }

        public string ErrorMessage { get; set; }
    }
}