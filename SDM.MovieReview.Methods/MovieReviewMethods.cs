using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using SDM.MoviewReview.Data;
using static System.IComparable;

namespace SDM.MovieReview.Methods
{
    public class MovieReviewMethods
    {

        private static  List<Movie.Movie> _movies; 
        public MovieReviewMethods(IDb ddb)
        {
            _movies = ddb.SeedMockList("c:/Users/Bruger/Downloads/ratings.json");
        }
     
        /*
        public static int binarySearch(List<Movie.Movie> movmov, Movie.Movie value)
       {
           movmov = _movies; 
           
           return 0;
       }
       */
      
        public int GetUserReviews(int n)
        {
            int count=0;

            foreach (var m in _movies)
                for (int i = 0; i < m.ReviewId; i++)
                {
                    if (m.ReviewId == n )
                    {
                        count++; 
                    }
                }
           

            return count;
        }
        
        
        
        

        public double GetAverageGradeByReviwer(int n)
        {
            double AverageGrades = 0;
            double value = 0;
            double count = 0; 
            
            foreach (var m in _movies)
            {
                if (m.ReviewId.Equals(n))
                {
                    value = value + m.Grade;
                    count++; 
                }
            }

            AverageGrades = value / count;
            return AverageGrades;
        }

        public int GetGradeCount(int n, int g)
        {
            int count = 0;
            foreach (var movie in _movies)
            {
                if(movie.ReviewId==n)
                {
                    if (movie.Grade==g)
                    {
                        count++; 
                    }
                }
            }
            
            
            return count;
        }
    }
}