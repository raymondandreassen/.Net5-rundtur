using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Shared.Model
{
    [Index("Rating")]
    public class BrukerInfo
    {
        [Key]
        public int InfoId { get; set;  }
        public string Title { get; set; }
        public string Content { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Rating { get; set; }
    }
}
