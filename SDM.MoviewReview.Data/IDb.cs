using System;
using System.Collections.Generic;
using SDM.MovieReview.Movie;

namespace SDM.MoviewReview.Data
{
    public interface IDb
    {
        List<Movie> SeedMockList(String filepath); 
        
    }
}