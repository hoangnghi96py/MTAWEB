﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TH13Chieu.Models.Entities
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
    }
}