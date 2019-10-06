using System;
using System.Reflection.Metadata;

namespace SDM.MovieReview.Movie
{
    public class Movie
    {
        public int ReviewId { get; set; }
        public int MovId { get; set; }
        public int Grade { get; set; }
        public DateTime GradeDate { get; set; }

       
    }
}