namespace MongoDbSharp.Model.MongoMainModel
{
    public class ExpertiseModel
    {
        public int value { get; set; }
        public string text { get; set; }
    }
    public class ExpertiseAreasResponse
    {
        public string Message { get; set; }
        public string Error { get; set; }
        public string BDJS { get; set; }
        public string searchText { get; set; }
        public List<ExpertiseModel> Data { get; set; }
    }
}
