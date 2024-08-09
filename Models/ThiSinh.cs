using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C1D1_DaoTrongHoan_2021606290.Models
{
    public class ThiSinh
    {
        public string sbd { get; set; }
        public string hoten { get; set; }
        public float diemtoan { get; set; }
        public float diemvan { get; set; }
        private float _TongDiem;
        public float TongDiem
        {
            get
            {
                return _TongDiem;
            }
            set
            {
                _TongDiem = diemtoan + diemvan;
            }
        }
        public ThiSinh(string sbd, string hoten, float diemtoan, float diemvan)
        {
            this.sbd = sbd;
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemvan = diemvan;
            this._TongDiem = diemtoan + diemvan;
        }
        public ThiSinh()
        {
        }
    }
}