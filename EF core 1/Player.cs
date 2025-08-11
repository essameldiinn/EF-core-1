using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_1
{
    [Table("Player")]
    internal class Player
    {
        [Key]
        public int PlayerNumber { get; set; }

        [Required]
        public string? Name { get; set; }

        [Column("RunnerTime", TypeName = "decimal(8, 2)")]
        public decimal RunnerTime { get; set; }

    }
}