using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandIDExcelAddin
{
    public class flow : ExProperties
    {
        public float CrossSection { get; set; }
        public float VolumetricFlowRate { get; set; }
        public float Velocity { get; set; }
    }
}
