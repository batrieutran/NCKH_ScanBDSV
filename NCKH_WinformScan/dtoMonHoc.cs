using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH_WinformScan
{
    public class dtoMonHoc 
    {
        private string tenMH;

        public dtoMonHoc(string tenMH)
        {
            this.tenMH = tenMH;
        }
        public dtoMonHoc()
        {
        }

        public string TenMH { get => tenMH; set => tenMH = value; }
    }
}
