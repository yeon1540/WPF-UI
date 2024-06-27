using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class AlarmHistory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OccurTime { get; set; }
        public string ClearTime { get; set; }
        public string Heavy { get; set; }
        public string Unit { get; set; }
    }
}
