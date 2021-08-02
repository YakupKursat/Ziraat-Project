using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewPostreSqlBackEnd.Models
{
    [Table("AddressInfo", Schema = "Address")]
    public partial class AddressInfo
    {
        public string Address { get; set; }
        [Key]
        [Column("StudentID")]
        public int StudentId { get; set; }
        public DateTime? RecordDateCode { get; set; }
        [StringLength(50)]
        public string RecordUserCode { get; set; }
        public short? RecordStatusCode { get; set; }
        [StringLength(50)]
        public string RecordScreenCode { get; set; }
    }
}
