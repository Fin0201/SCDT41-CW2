using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    internal class CosmeticService
    {
        public Guid Id { get; set; }
        public string ServiceDescription { get; set; }
        public DateTime DateBooked { get; set; }
    }
}
