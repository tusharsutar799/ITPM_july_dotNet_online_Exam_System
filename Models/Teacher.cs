using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online_Examination_system.Models
{
    public class Teacher
    {

        
            public class TeacherForm
            {
                [Key] 
                public int TeacherId { get; set; }

                public string TeacherName { get; set; }

                [EmailAddress] 
                public string TeacherEmail { get; set; }

                public string InstituteId { get; set; }

                public string TeacherUsername { get; set; }

                public string TeacherPassword { get; set; }
            }

            public class TeacherClassroom
            {
                [Key] 
                public int ClassroomId { get; set; }

                [ForeignKey("TeacherForm")] 
                public int TeacherId { get; set; }

                [Column(TypeName = "date")] 
                public DateTime Date { get; set; }

               [Key]
                public int ExamId { get; set; }

                public string Description { get; set; }

                public string TeacherExamName { get; set; }

                public virtual StudentForm Teacher { get; set; } 
            }

            public class ClassroomQuestion
            {
                [Key] 
                public int QuestionId { get; set; }

                [ForeignKey("TeacherClassroom")] 
                public int ExamId { get; set; }
                public string Questions { get; set; }

                public string Option1 { get; set; }

                public string Option2 { get; set; }

                public string Option3 { get; set; }

                public string Option4 { get; set; }

                public string CorrectOption { get; set; }

                public virtual TeacherClassroom TeacherClassroom { get; set; } 
            }
        }
    }