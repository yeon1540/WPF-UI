﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class UserInfo
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Level { get; set; }
    }
}
