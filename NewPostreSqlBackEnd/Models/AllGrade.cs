using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewPostreSqlBackEnd.Models
{
    [Keyless]
    [Table("AllGrades", Schema = "Grades")]
    public partial class AllGrade
    {
        [Column("StudentID")]
        public int? StudentId { get; set; }
        public short? LectureCode { get; set; }
        public decimal? Grade { get; set; }
        public short? ExamType { get; set; }
        public DateTime? RecordDateCode { get; set; }
        [StringLength(50)]
        public string RecordUserCode { get; set; }
        public short? RecordStatusCode { get; set; }
        [StringLength(50)]
        public string RecordScreenCode { get; set; }
    }
}
