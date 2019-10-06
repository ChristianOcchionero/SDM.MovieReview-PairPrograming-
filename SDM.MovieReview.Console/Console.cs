using System.Data.Common;
using System.Threading;
using SDM.MoviewReview.Data;

namespace SDM.MovieReview.Console
{
    using System; 
    public class Console
    {
        static void Main(string[] args)
        {
            
        } 
        
        public void prinList()
        {
            IDb db = new FakeDb() ;
           // db.SeedMockList("");
            foreach (var m in db.SeedMockList(""))
            {
                System.Console.WriteLine("here is a list of all movies");
                
            }
          

        }
        
        
    }
}