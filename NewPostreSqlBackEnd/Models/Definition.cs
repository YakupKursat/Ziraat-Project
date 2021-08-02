using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewPostreSqlBackEnd.Models
{
    [Table("Definitions", Schema = "SystemDefinitions")]
    public partial class Definition
    {
        [StringLength(10)]
        public string Key { get; set; }
        public short? Code { get; set; }
        [Key]
        [Column("ValueID")]
        [StringLength(20)]
        public string ValueId { get; set; }
        public DateTime? RecordDateCode { get; set; }
        [StringLength(50)]
        public string RecordUserCode { get; set; }
        public short? RecordStatusCode { get; set; }
        [StringLength(50)]
        public string RecordScreenCode { get; set; }
    }
}
