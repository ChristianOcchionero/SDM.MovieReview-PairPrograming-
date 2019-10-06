using System;
using System.Collections.Generic;
using SDM.MovieReview.Movie;

namespace SDM.MoviewReview.Data
{
    public class MockDb:IDb
    {
        public List<Movie> SeedMockList(String filepath)
        {

         List<Movie> MockMovList = new List<Movie>();
            Movie m1 = new Movie();
            Movie m2=new Movie();
            Movie m3 = new Movie();
            Movie m4 = new Movie();

            m1.ReviewId = 1;
            m1.MovId = 1;
            m1.Grade = 4;
            m1.GradeDate= DateTime.Now;
            MockMovList.Add(m1);
            
            m2.ReviewId = 1;
            m2.MovId = 2;
            m2.Grade = 5;
            m2.GradeDate= DateTime.Now;
            MockMovList.Add(m2);
            
            m3.ReviewId = 3;
            m3.MovId = 1;
            m3.Grade = 1;
            m3.GradeDate= DateTime.Now;
            MockMovList.Add(m3);
            
            m4.ReviewId = 3;
            m4.MovId = 1;
            m4.Grade = 1;
            m4.GradeDate= DateTime.Now;
            MockMovList.Add(m4);
            return MockMovList;
        }

        
    }
}