namespace UniCareer.API.Models
{
    public class JobApplication
    {
        public int Id {get; set;}
        public string CompanyName {get; set;} = string.Empty;
        public string JobTitle {get; set;} = string.Empty;
        public JobStatus Status {get; set;} = JobStatus.Saved;
        public DateTime? InterviewDate {get; set;}
        public string? CVFilePath {get; set;}
        public int UserId {get; set;}
    }

    public enum JobStatus
    {
        Saved,
        Applied,
        Interviewing,
        Offered,
        Rejected
    }
}