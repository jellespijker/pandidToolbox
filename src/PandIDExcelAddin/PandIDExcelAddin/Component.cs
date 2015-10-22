using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandIDExcelAddin
{
    public class Component : flow
    {
        public string Figure { get; set; }
        public float Kv { get; set; }
        public int Qt { get; set;  }
        public float Ktot
        {
            get
            {
                return Kv * Qt;
            }
        }
        public float E_loss
        {
            get
            {
                return 1;
            }
        }
    }
}
