using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private string _TenXe;

        private string _BangLai;
        private int _KhoangCach;
        private DateTime? _GioKhoiHanh;
        private string _TenLoai;
        private string _SoDangKy;
        private string _TenTaiXe;

        public string TenXe
        {
            get
            {
                return _TenXe;
            }

            set
            {
                _TenXe = value;
            }
        }

        public string TenLoai
        {
            get
            {
                return _TenLoai;
            }

            set
            {
                _TenLoai = value;
            }
        }

        public string SoDangKy
        {
            get
            {
                return _SoDangKy;
            }

            set
            {
                _SoDangKy = value;
            }
        }

        public string BangLai
        {
            get
            {
                return _BangLai;
            }

            set
            {
                _BangLai = value;
            }
        }

        public int KhoangCach
        {
            get
            {
                return _KhoangCach;
            }

            set
            {
                _KhoangCach = value;
            }
        }

        public DateTime? GioKhoiHanh
        {
            get
            {
                return _GioKhoiHanh;
            }

            set
            {
                _GioKhoiHanh = value;
            }
        }

        public string TenTaiXe
        {
            get
            {
                return _TenTaiXe;
            }

            set
            {
                _TenTaiXe = value;
            }
        }
        public User(string TenXe, string LoaiXe, string SoDangKy, string TenTaiXe, string BangLai, int KhoangCach, DateTime? GioiKhoiHanh)
        {
            this.TenXe = TenXe;
            this.TenLoai = LoaiXe;
            this.SoDangKy = SoDangKy;
            this.TenTaiXe = TenTaiXe;
            this.BangLai = BangLai;
            this.KhoangCach = KhoangCach;
            this.GioKhoiHanh = GioiKhoiHanh;
        }
    }

    public class ThongTinChuyen
    {
        string iD_Chuyen;
        string gio_Khoi_Hanh;
        string xe_XeID;
        string tai_xe_ID_TaiXe;
        int khoangCachDi;
        string thoiGianChay;

        public string ID_Chuyen { get => iD_Chuyen; set => iD_Chuyen = value; }
        public string Gio_Khoi_Hanh { get => gio_Khoi_Hanh; set => gio_Khoi_Hanh = value; }
        public string Xe_XeID { get => xe_XeID; set => xe_XeID = value; }
        public string Tai_xe_ID_TaiXe { get => tai_xe_ID_TaiXe; set => tai_xe_ID_TaiXe = value; }
        public int KhoangCachDi { get => khoangCachDi; set => khoangCachDi = value; }
        public string ThoiGianChay { get => thoiGianChay; set => thoiGianChay = value; }

        public ThongTinChuyen(string id_Chuyen,string gio_Khoi_Hanh,string xe_XeID,string tai_xe_ID_TaiXe,int khoangCach,string thoiGianChay)
        {
            this.ID_Chuyen = id_Chuyen;
            this.Gio_Khoi_Hanh = gio_Khoi_Hanh;
            this.Xe_XeID = xe_XeID;
            this.Tai_xe_ID_TaiXe = tai_xe_ID_TaiXe;
            this.KhoangCachDi = khoangCach;
            this.ThoiGianChay = thoiGianChay;
        }
    }

    public class ThongTinKhachHang
    {
        int _id;
        string _sdt;
        string _tenKhachHang;
        string _loaiKhachHang;
        string _email;

        public int Id { get => _id; set => _id = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
        public string LoaiKhachHang { get => _loaiKhachHang; set => _loaiKhachHang = value; }
        public string Email { get => _email; set => _email = value; }

        public ThongTinKhachHang(int id,string ten,string loai,string sdt,string email)
        {
            this.Id = id;
            this.Sdt = sdt;
            this.TenKhachHang = ten;
            this.LoaiKhachHang = loai;
            this.Email = email;
        }

        public ThongTinKhachHang()
        {

        }
    }

    public class Ve
    {
        string _id_Ve;
        string _ghe_ID_Ghe;
        string _chuyen_ID_Chuyen;
        string _tinhTrang;
        float _giaTien;
        int _khachHang_ID_KhachHang;
        DateTime _ngayXuatVe;
        string _ghiChu;

        public string Id_Ve { get => _id_Ve; set => _id_Ve = value; }
        public string Ghe_ID_Ghe { get => _ghe_ID_Ghe; set => _ghe_ID_Ghe = value; }
        public string Chuyen_ID_Chuyen { get => _chuyen_ID_Chuyen; set => _chuyen_ID_Chuyen = value; }
        public int KhachHang_ID_KhachHang { get => _khachHang_ID_KhachHang; set => _khachHang_ID_KhachHang = value; }
        public DateTime NgayXuatVe { get => _ngayXuatVe; set => _ngayXuatVe = value; }
        public float GiaTien { get => _giaTien; set => _giaTien = value; }
        public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }

        public Ve(string idVe,string idGhe,string idChuyen,int idKh,DateTime ngayXuatVe,string ghiChu,float giaTien,string tinhTrang)
        {
            this.Id_Ve = idVe;
            this.Ghe_ID_Ghe = idGhe;
            this.Chuyen_ID_Chuyen = idChuyen;
            this.TinhTrang = tinhTrang;
            this.GiaTien = giaTien;
            this.KhachHang_ID_KhachHang = idKh;
            this.NgayXuatVe = ngayXuatVe;
            this.GhiChu = ghiChu;
        }
    }
}
