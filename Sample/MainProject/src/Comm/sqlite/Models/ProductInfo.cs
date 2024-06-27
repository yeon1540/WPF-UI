using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class ProductInfo
    {
        public string Id { get; set; }
        public long Port { get; set; }
        public long Slot { get; set; }
        public string Stage { get; set; }
        public long State { get; set; }
        public string LotId { get; set; }
        public string ProductId { get; set; }
        public string Recipe { get; set; }
        public byte[] PinfoBlob { get; set; }
    }
}
