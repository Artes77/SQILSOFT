﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Data
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PermissionName { get; set; }
    }
}