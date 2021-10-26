namespace MoviesProy.Shared.Entity
{
    public class MovieActor
    {
        public int MovieId{get;set;}
        public int ActorId{get;set;}
        public Actor Actor{get;set;}
        public Movie Movie{get;set;} 
        public int OrderCredits{get;set;}
        public string Character{get;set;}
    }
}