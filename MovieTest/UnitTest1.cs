using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM.MovieReview.Methods;
using SDM.MovieReview.Movie;
using SDM.MoviewReview.Data;

namespace MovieTest
{
   
    [TestClass]
    public class UnitTest1
    {
        private MockDb mocker = new MockDb();
        
        
        [TestMethod]
        public void GetUserReview_Test()
        {
           
            MovieReviewMethods Mock = new MovieReviewMethods(mocker);
            Assert.AreEqual(2, Mock.GetUserReviews(1));
        }

        [TestMethod]
        public void GetAverageGradeByReviwer_test()
        {
           
            MovieReviewMethods Mock = new MovieReviewMethods(mocker);
            
            Assert.AreEqual(4.5, Mock.GetAverageGradeByReviwer(1));
        }
        
        [TestMethod]
        public void GetGradeCount_test()
        {
         
            MovieReviewMethods Mock = new MovieReviewMethods(mocker);
            
            Assert.AreEqual(1, Mock.GetGradeCount(1,4));
        }
    }
}