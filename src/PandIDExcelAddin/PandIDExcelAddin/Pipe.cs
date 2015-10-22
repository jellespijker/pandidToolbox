using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandIDExcelAddin
{
    public class Pipe : flow
    {
        private bool _recalc = true;
        private float _dia;
        public float Dia
        {
            get
            {
                return _dia;
            }
            set
            {
                _dia = value;
            }
        }
        private float _length;
        public float Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
                _recalc = true;
            }
        }

    }
}
