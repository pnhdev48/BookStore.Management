﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Management.Domain.Entities
{
    public class Genre : BaseEntity
    {
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
