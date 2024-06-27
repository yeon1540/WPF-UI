using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class ScreenInfo
    {
        public string Id { get; set; }
        public long Auto { get; set; }
        public long Manual { get; set; }
        public long Recipe { get; set; }
        public long System { get; set; }
    }
}
