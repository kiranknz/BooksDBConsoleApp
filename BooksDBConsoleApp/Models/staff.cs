using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BooksDBConsoleApp.Models
{
    [Table("Staff")]
    public partial class staff
    {
        [Key]
        public int StaffID { get; set; }
        [StringLength(50)]
        public string StaffName { get; set; } = null!;
    }
}
