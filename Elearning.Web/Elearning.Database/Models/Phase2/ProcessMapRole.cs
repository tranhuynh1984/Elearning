﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Elearning.Database.Models
{
    public class ProcessMapRole : UpdateTime
    {
        [Required]
        public int IDRole { get; set; }
        [Required]
        public string GroupCode { get; set; }
    }
}