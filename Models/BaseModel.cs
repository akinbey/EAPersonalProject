﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime DataCreated { get; set; } = DateTime.Now;
        public DateTime? DataModified { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleteds { get; set; } = false;

    }
}
