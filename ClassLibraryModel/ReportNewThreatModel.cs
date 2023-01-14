using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class ReportNewThreatModel
    {
        public int ThreatId { get; set; }   
        public string?Name { get; set; }
        public string? Email { get; set; }
        public string? ThreatDescription { get; set; }

    }
}
