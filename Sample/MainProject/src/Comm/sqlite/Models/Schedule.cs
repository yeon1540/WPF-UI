using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class Schedule
    {
        public string Unit { get; set; }
        public string ProductId { get; set; }
        public long RunIndex { get; set; }
        public long SeqIndex { get; set; }
        public long CmdIndex { get; set; }
        public long EnetUse { get; set; }
        public string EnetIp { get; set; }
        public string EnetPort { get; set; }
        public long SerialUse { get; set; }
        public string SerialPort { get; set; }
        public string SerialBuad { get; set; }
        public string SendMsg { get; set; }
        public string ReciveMsg { get; set; }
    }
}
