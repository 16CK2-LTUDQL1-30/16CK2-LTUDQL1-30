using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        private static UserBUS instance;//kỹ thuật singleton parttern: chỉ sử dụng một thực thể instance duy nhất

        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBUS();
                }
                return instance;
            }
        }
        private UserBUS() { }
        public void Load_DSChuyen(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.Load_DSChuyen();
        }

        public List<string> Load_Tuyen()
        {
            return UserDAO.Instance.Load_Tuyen();
        }

        public List<string> Load_DiaDiem(string diemBatDau,string diemDen)
        {
            return UserDAO.Instance.Load_DiaDiem(diemBatDau,diemDen);
        }

        public void Load_ThongTin(DataGridView data, string diemBatDau, string diemDen, int year, int month, int day)
        {
            data.DataSource =  UserDAO.Instance.LoadThongTin(diemBatDau, diemDen, year, month, day);
        }

        public List<string> LoadIdTuyen(string diemBatDau, string diemDen, int year, int month, int day)
        {
            return UserDAO.Instance.LoadIdChuyen(diemBatDau, diemDen, year, month, day);
        }

        public string LoadSoChoDaDat(string idChuyen)
        {
            return UserDAO.Instance.LoadSoChoDaDat(idChuyen);
        }

        public string LoadTenKhachHang(string sdt)
        {
            if (UserDAO.Instance.LoadThongTinKhachHang(sdt).TenKhachHang == null)
            {
                return "false";
            }
            else
            {
                return UserDAO.Instance.LoadThongTinKhachHang(sdt).TenKhachHang.ToString();
            }
        }

        public string LoadLoaiKhachHang(string sdt)
        {
            return UserDAO.Instance.LoadThongTinKhachHang(sdt).LoaiKhachHang.ToString();
        }

        public int LoadIdKhachHang(string sdt)
        {
            return UserDAO.Instance.LoadThongTinKhachHang(sdt).Id;
        }

        public string LoadEmailKhachHang(string sdt)
        {
            return UserDAO.Instance.LoadThongTinKhachHang(sdt).Email.ToString();
        }

        public DataTable LoadSoDongSoCot(string idChuyen)
        {
            return UserDAO.Instance.LoadSoDongSoCot(idChuyen);
        }

        public DataTable LoadTinhTrangGhe(string idChuyen)
        {
            return UserDAO.Instance.LoadTinhTrangGhe(idChuyen);

        }

        public string LoadIdXe(string idChuyen)
        {
            return UserDAO.Instance.LoadIdXe(idChuyen);
        }

        public bool ThemVe(string idVe, string idGhe, string idChuyen, string tinhTrang, float giaTien, int idKh, DateTime ngayXuatVe, string ghiChu)
        {
            Ve info = new Ve(idVe, idGhe, idChuyen, idKh, ngayXuatVe, ghiChu, giaTien, tinhTrang);
            return UserDAO.Instance.ThemVe(info);
        }

        public string LayIDVeGanNhat()
        {
            return UserDAO.Instance.LayIDVeGanNhat();
        }

        public string LayIDKhachGanNhat()
        {
            return UserDAO.Instance.LayIDKhachGanNhat();
        }

        public bool ThemKhachHang(int idKh,string hoTen,string sdt,string email,string loai)
        {
            ThongTinKhachHang kh = new ThongTinKhachHang(idKh, hoTen, loai, sdt, email);
            return UserDAO.Instance.ThemKhachHang(kh);
        }

        public bool HuyVe(string idGhe, string sdt)
        {
            return UserDAO.Instance.HuyVe(idGhe, sdt);
        }
    }
}
