﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Create.Models
{
    public class EmailConfirm
    {
        public string Email { get; set; }

        public bool IsConfirmed { get; set; }

        public bool EmailSent { get; set; }

        public bool EmailVerified { get; set; }
    }
}
