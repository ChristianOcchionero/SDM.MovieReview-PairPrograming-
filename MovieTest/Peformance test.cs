using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM.MovieReview.Methods;
using SDM.MoviewReview.Data;

namespace MovieTest
{
    [TestClass]
    public class Peformance_test
    {
        private Db mocker = new Db("c:/Users/Bruger/Downloads/ratings.json");
        private Stopwatch _stopwatch = new Stopwatch();
        
        [TestMethod]
        public void GetUserReview_Test()
        {
            bool g = false;
            MovieReviewMethods Mock = new MovieReviewMethods(mocker);
            _stopwatch.Start();
            Mock.GetUserReviews(3);
            _stopwatch.Stop();
            if (_stopwatch.ElapsedMilliseconds / 1000.0 > 4.0)
            {
                g = true;
            }
            
            Assert.IsTrue(g);
        }
    }
}