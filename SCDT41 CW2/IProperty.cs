using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    public interface IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
    }
}
