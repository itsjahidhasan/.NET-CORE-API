using System.ComponentModel.DataAnnotations;

namespace TrackingAPI.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public Priorty Priorty { get; set; }
        public IssueType IssueType { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

    }
    public  enum Priorty
    {
        low,
        Meduim,
        High,  
    }
    public enum IssueType
    {
        Feature,Bug,Documentation
    }
}
