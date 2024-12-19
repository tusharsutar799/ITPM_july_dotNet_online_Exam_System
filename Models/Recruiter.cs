using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online_Examination_system.Models
{
    public class RecruiterForm
    {
        [Key] 
        public int RecruiterId { get; set; }

        public string RecruiterName { get; set; }

        [EmailAddress] 
        public string RecruiterEmail { get; set; }

        public string OrganizationName { get; set; }

        public string RecruiterUsername { get; set; }

        public string RecruiterPassword { get; set; }
    }

    public class RecruiterExam
    {
        [Key]
        public int RecruiterExamId { get; set; }

        [ForeignKey("RecruiterForm")] 
        public int RecruiterId { get; set; }

        [Column(TypeName = "date")] 
        public DateTime Date { get; set; } 

        public string Description { get; set; }

        public string RecruiterExamName { get; set; }

        public virtual RecruiterForm Recruiter { get; set; } 
    }

    public class RecruiterQuestion
    {
        [Key]
        public int QuestionId { get; set; }

        [ForeignKey("RecruiterExam")] 
        public int RecruiterExamId { get; set; }

        public string Questions { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

        public string CorrectOption { get; set; }

        public virtual RecruiterExam RecruiterExam { get; set; } 
    }



}