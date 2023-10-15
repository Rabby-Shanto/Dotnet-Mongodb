using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSharp.Model.DTO
{
    public class CommentsDataDTO
    {
        public int cmtId { get; set; }
        public int ApplyID { get; set; }
        public byte LevelStatus { get; set; }
        public string Comment { get; set; }
    }
}
