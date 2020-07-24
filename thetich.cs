using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinh_the_tich_hinh_tru
{
    class thetich
    {
        private double r, h,kq;
        public thetich(double r, double h )
        {
            this.r = r; this.h = h ;
        }
        public double bankinh
        {
            get { return this.r; }
            set { r = value; }
        }

        public double duongcao
        {
            get { return this.h; }
            set { h = value; }
        }
        public double ketqua
        {
            get { return this.kq; }
        }
        public double tinhthetich()
        {
            return kq = Math.PI * (r * r) * h;
        }
    }
}
