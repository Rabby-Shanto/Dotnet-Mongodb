using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSharp.Model.DTO
{
    public class ApplicantProcessInfoDTO
    {
        public int ApplyID { get; set; }
        public int prId { get; set; }
        public byte LevelStatus { get; set; }
        public int SchId { get; set; }
        public bool Notify { get; set; }
        public byte Attended { get; set; }
        public double Score { get; set; }
        public bool Rejected { get; set; }
        public int stId { get; set; }
        public string TestName { get; set; }
    }
}
