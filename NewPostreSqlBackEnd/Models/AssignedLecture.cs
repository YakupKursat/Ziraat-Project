using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewPostreSqlBackEnd.Models
{
    [Keyless]
    [Table("AssignedLectures", Schema = "Assigned")]
    public partial class AssignedLecture
    {
        public short? LectureCode { get; set; }
        [Column("StudentID")]
        public int? StudentId { get; set; }
        public DateTime? RecordDateCode { get; set; }
        [StringLength(50)]
        public string RecordUserCode { get; set; }
        public short? RecordStatusCode { get; set; }
        [StringLength(50)]
        public string RecordScreenCode { get; set; }
    }
}
