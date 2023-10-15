using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSharp.Model.DTO
{
    public class ExprienceCardViewDataDTO
    {
        public int P_ID { get; set; }
        public int EX_ID { get; set; }
        public string COMPANY { get; set; }
        public string EPOSITION { get; set; }
        public DateTime? EFROM { get; set; }
        public DateTime? ETO { get; set; }
        public bool SERVE_TILL { get; set; }
        public int TExp { get; set; }
    }
}
