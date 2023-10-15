using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSharp.Model.MongoMainModel
{
    public class IndustryModel
    {
        public string value { get; set; }
    }
    public class BusinessOrganizationsResponse
    {
        public string Message { get; set; }
        public string Error { get; set; }
        public string BDJS { get; set; }
        public string searchText { get; set; }
        public List<IndustryModel> Data { get; set; }
    }
}
