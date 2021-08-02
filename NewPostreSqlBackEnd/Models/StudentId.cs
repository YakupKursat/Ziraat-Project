using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewPostreSqlBackEnd.Models
{
    [Table("StudentId", Schema = "Student")]
    public partial class StudentId
    {
        [Key]
        [Column("StudentID")]
        public int StudentId1 { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public int? Country { get; set; }
        public short? City { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        public short? Gender { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }
        public DateTime? RecordDateCode { get; set; } = DateTime.Now;
        public string RecordUserCode { get; set; }
        public short? RecordStatusCode { get; set; }
        [StringLength(20)]
        public string RecordScreenCode { get; set; }
    }
}
