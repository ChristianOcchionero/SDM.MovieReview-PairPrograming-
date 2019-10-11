using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SDM.MovieReview.Movie;

namespace SDM.MoviewReview.Data
{
    public class Db:IDb
    {
        public Db(String filepath)
        {
            SeedMockList( filepath);

        }
        public List<Movie > SeedMockList(String filepath)
        {
            string result = string.Empty;
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                List<Movie> MovList = JsonConvert.DeserializeObject<List<Movie>>(json);
                return MovList;
            }
        }

      
    }
}