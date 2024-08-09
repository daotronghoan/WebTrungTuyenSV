using C1D1_DaoTrongHoan_2021606290.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C1D1_DaoTrongHoan_2021606290.Controllers
{
    public class QuanLyThiSinhController : Controller
    {
        // GET: QuanLyThiSinh
        public ActionResult Index()
        {
            return View();
        }
        static List<ThiSinh> danhsach = new List<ThiSinh>();
        public QuanLyThiSinhController()
        {
            
            if (danhsach.Count == 0)
            {
                danhsach.Add(new ThiSinh("haui01", "Nguyen Van A", 6.0f, 3.0f));
                danhsach.Add(new ThiSinh("haui02", "Tran Van B", 8f, 8f));
                danhsach.Add(new ThiSinh("haui03", "Ngo Thi C", 8f, 4f));
                danhsach.Add(new ThiSinh("haui04", "Vu Thi D", 9f, 8f));
                danhsach.Add(new ThiSinh("haui05", "Truong Van E", 10f, 9f));
                danhsach.Add(new ThiSinh("haui06", "Le Thi F", 9f, 2f));
                danhsach.Add(new ThiSinh("haui07", "Tran Thi G", 8f, 3f));
            }
        }
        public ActionResult ThiSinhList()
        {
            return View(danhsach);
        }
        public ActionResult TrungTuyen()
        {
            if (danhsach == null)
            {
                ThiSinhList();
            }
            var danhSachSoLuongHS = danhsach.Where(sp => sp.TongDiem >= 16).ToList();
            return View(danhSachSoLuongHS);
        }
        public ActionResult Olympic()
        {
            if (danhsach == null)
            {
                ThiSinhList();
            }
            var danhSachSoLuongHS = danhsach.Where(sp => sp.diemtoan > 5).ToList();
            return View(danhSachSoLuongHS);
        }
 
        public ActionResult InformationDisplay(string sbd, string hoten, float diemtoan=0, float diemvan=0)
        {
            danhsach.Add(new ThiSinh(sbd, hoten, diemtoan, diemvan));
            return RedirectToAction("ThiSinhList");
        }
        public ActionResult HienThiSV()
        {
            return View(danhsach);
        }
        public ActionResult NhapSV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NhapSV(string sbd, string hoten, float diemtoan = 0, float diemvan = 0)
        {
            danhsach.Add(new ThiSinh(sbd, hoten, diemtoan, diemvan));
            return RedirectToAction("HienThiSV");
        }
    }
}





//public ActionResult NhapSV(ThiSinh ts)
//{
//    return View(ts);
//}
//public ActionResult InformationDisplay(ThiSinh TS)
//{ 
//    ThiSinhList();
//    if (danhsach == null)
//    {
//        danhsach = new List<ThiSinh>();
//    }
//    ThiSinh ts = new ThiSinh();
//    ts.sbd = TS.sbd;
//    ts.hoten = TS.hoten;
//    ts.diemtoan = TS.diemtoan;
//    ts.diemvan = TS.diemvan;
//    ts.TongDiem = TS.TongDiem;
//    danhsach.Add(ts);
//    return View(danhsach);
//}
//public ActionResult InformationDisplay(ThiSinh ts)
//{
//    ts.TongDiem = ts.diemtoan + ts.diemvan;
//    danhsach.Add(ts);
//    return View(danhsach);
//}

//danhsach = new List<ThiSinh>();
//danhsach.Add(new ThiSinh("haui01", "Nguyen Van A", 6.0f, 3.0f));
//danhsach.Add(new ThiSinh("haui02", "Tran Van B", 8f, 8f));
//danhsach.Add(new ThiSinh("haui03", "Ngo Thi C", 8f, 4f));
//danhsach.Add(new ThiSinh("haui04", "Vu Thi D", 9f, 8f));
//danhsach.Add(new ThiSinh("haui05", "Truong Van E", 10f, 9f));
//danhsach.Add(new ThiSinh("haui06", "Le Thi F", 9f, 2f));
//danhsach.Add(new ThiSinh("haui07", "Tran Thi G", 8f, 3f));