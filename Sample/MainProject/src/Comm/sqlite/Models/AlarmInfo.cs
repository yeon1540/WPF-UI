using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class AlarmInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string KorCommant { get; set; }
        public string EngComment { get; set; }
        public string ChiComment { get; set; }
        public string KorDescription { get; set; }
        public string EngDescription { get; set; }
        public string ChiDescription { get; set; }
        public string KorSolution { get; set; }
        public string EngSolution { get; set; }
        public string ChiSolution { get; set; }
        public string Unit { get; set; }
        public string Heavy { get; set; }
        public long IsAlive { get; set; }
        public long Count { get; set; }
        public string ImageDir { get; set; }
    }
}
