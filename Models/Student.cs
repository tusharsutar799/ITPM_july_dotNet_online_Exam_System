using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace online_Examination_system.Models
{
    public class StudentForm
    {
        [Key] 
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        [EmailAddress] 
        public string StudentEmail { get; set; }

        [Phone] 
        public long MobileNumber { get; set; }

        public string StudentUsername { get; set; }

        public string StudentPassword { get; set; }
    }

    public class StudentClassroom
    {
        [Key] // Primary Key
        public int ClassroomStudentId { get; set; }

        [ForeignKey("StudentForm")] 
        public int StudentId { get; set; }

        
        public int ClassroomId { get; set; }

        public virtual StudentForm Student { get; set; } 
    }

    public class StudentClassroomExam
    {
        [Key] 
        public int ResultId { get; set; }

        [ForeignKey("StudentClassroom")] 
        public int ClassroomStudentId { get; set; }

        [ForeignKey("TeacherClassroom")] 
        public int ExamId { get; set; }

        public virtual StudentClassroom StudentClassroom { get; set; } 
    }

}