using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABDOTClient.Model
{
    public class Movie
    {
    
      
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Language { get; set; }
        public string SubtitleLanguage { get; set; }
        public int Year { get; set; }
        public int LengthInMinutes { get; set; }
        public string PosterSrc { get; set; }
        
    }
}