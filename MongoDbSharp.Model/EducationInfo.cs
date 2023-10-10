namespace MongoDbSharp.Model
{
    public class EducationInfo
    {
        public int P_ID { get; set; }
        public string EDUCATION { get; set; }
        public string INSTITUTE { get; set; }
        public string SUBJECT { get; set; }
        public byte EDULEVEL2 { get; set; }
        public bool F_INSTITUTE { get; set; }
        public byte RESULT { get; set; }
        public double PERCENT_MARK { get; set; }
        public byte GRADE_SCALE { get; set; }
        public string ACHIEVEMENT { get; set; }
        public string EducationTypeOthers { get; set; }
        public string FICountry { get; set; }
    }
}

