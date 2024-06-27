using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class Product
    {
        public string Id { get; set; }
        public string LotId { get; set; }
        public string BlockId { get; set; }
        public string Recipe { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public byte[] ProductBlob { get; set; }
    }
}
