using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSharp.Model.MongoMainModel
{
    public class CvBank
    {
        public string Error { get; set; }
        public string Message { get; set; }
        public string SQL { get; set; }
        public int TotalCV { get; set; }
        public int TotalStarC { get; set; }
    }
}
