using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewPostreSqlBackEnd.Models
{
    [Table("LectureDefiniton", Schema = "Lecture")]
    public partial class LectureDefiniton
    {
        [Key]
        [Column("LectureID")]
        public short LectureId { get; set; }
        [StringLength(20)]
        public string LectureName { get; set; }
        public DateTime? RecordDateCode { get; set; }
        [StringLength(50)]
        public string RecordUserCode { get; set; }
        public short? RecordStatusCode { get; set; }
        [StringLength(50)]
        public string RecordScreenCode { get; set; }
    }
}
