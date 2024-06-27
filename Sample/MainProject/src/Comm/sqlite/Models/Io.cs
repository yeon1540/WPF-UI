using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class Io
    {
        public string Id { get; set; }
        public long Division { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public long Aslive { get; set; }
    }
}
