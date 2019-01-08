using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;//kỹ thuật singleton parttern: chỉ sử dụng một thực thể instance duy nhất

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        private UserDAO() { }
        public List<User> Load_DSChuyen()
        {
            List<User> users = new List<User>();
            Provider p = new Provider();
            try
            {
                string strSql = "select x.TenXe, lx.TenLoai, x.So_dang_ky, tx.TenTaiXe , tx.BangLai, t.KhoangCach, c.Gio_khoi_hanh from Xe x, LoaiXe lx, Chuyen c, Tai_xe tx, Tuyen t where x.LoaiXe_ID_LoaiXe = lx.ID_LoaiXe and c.Xe_XeID = x.XeID and c.Tai_xe_ID_TaiXe = tx.ID_TaiXe and c.Tuyen_ID_Tuyen = t.ID_Tuyen group by x.TenXe, lx.TenLoai, x.So_dang_ky, tx.TenTaiXe, tx.BangLai, t.KhoangCach, c.Gio_khoi_hanh";
                p.Connect();
                DataTable dt = p.Select(CommandType.Text, strSql);
                foreach (DataRow item in dt.Rows)
                {
                    string tenXe = item["TenXe"].ToString();
                    string tenLoai = item["TenLoai"].ToString();
                    string soDangKy = item["So_dang_ky"].ToString();
                    string tenTaiXe = item["TenTaiXe"].ToString();
                    int khoangCach = Convert.ToInt32(item["KhoangCach"]);
                    //DateTime? kiểm tra null
                    //nếu thoiGianChay = empty thì trả ra null còn ngược lại trả ra datetime
                    DateTime? thoiGianChay = item["Gio_khoi_hanh"].ToString() == string.Empty ? null : (DateTime?)item["Gio_khoi_hanh"];
                    string bangLai = item["BangLai"].ToString();

                    User newUser = new User(tenXe, tenLoai, soDangKy, tenTaiXe, bangLai, khoangCach, thoiGianChay);
                    users.Add(newUser);
                }
                return users;
            }
            catch (SqlException ex)
            { throw ex; }
        }

        public List<string> Load_Tuyen()
        {
            List<string> ls = new List<string>();
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT tr.TenTram as Tram1, tr1.TenTram as Tram2 FROM Tram tr, Tuyen t, Tram tr1 WHERE t.Tram_ID_Tram1 = tr.ID_Tram and t.Tram_ID_Tram = tr1.ID_Tram";
                DataTable ls1 = provider.SelectNonPara(CommandType.Text, query);
                int i = 0;
                int flag = 0;
                foreach (DataRow item in ls1.Rows)
                {
                    string Tram1 = item["Tram1"].ToString();
                    string Tram2 = item["Tram2"].ToString();
                    string result = Tram1 + '-' + Tram2;
                    i = 0;
                    flag = 0;
                    foreach (string item1 in ls)
                    {
                        if (result == item1.ToString())
                        {
                            flag = 1;
                            break;
                        }
                        i++;
                    }
                    if (flag == 0)
                    {
                        ls.Add(result);
                    }
                }
                return ls;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return ls;
        }

        public List<string> Load_DiaDiem(string diemBatDau,string diemDen)
        {
            List<string> ls = new List<string>();
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT t.ID_Tuyen , tr.Dia_Diem as Diem1 , tr1.Dia_Diem as Diem2 FROM Tram tr , Tuyen t , Tram tr1 WHERE t.Tram_ID_Tram1 = tr.ID_Tram and t.Tram_ID_Tram = tr1.ID_Tram and tr.TenTram = @diemBatDau and tr1.TenTram = @diemDen";
                DataTable ls1 = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@diemBatDau", Value = diemBatDau },
                                                new SqlParameter {ParameterName = "@diemDen", Value = diemDen});
                foreach (DataRow item in ls1.Rows)
                {
                    string diaDiem1 = item["Diem1"].ToString();
                    string diaDiem2 = item["Diem2"].ToString();
                    string result = diaDiem1 + '-' + diaDiem2;
                    ls.Add(result);
                }
                return ls;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public List<ThongTinChuyen> LoadThongTin(string diemBatDau,string diemDen,int year,int month,int day)
        {
            List<ThongTinChuyen> ls = new List<ThongTinChuyen>();
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT t.ID_Tuyen FROM Tram tr, Tuyen t, Tram tr1 WHERE t.Tram_ID_Tram1 = tr.ID_Tram and t.Tram_ID_Tram = tr1.ID_Tram and tr.Dia_Diem = @diemBatDau and tr1.Dia_Diem = @diemDen";
                DataTable id_Tuyen = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@diemBatDau", Value = diemBatDau },
                                                new SqlParameter { ParameterName = "@diemDen", Value = diemDen });
                string id = id_Tuyen.Rows[0][0].ToString();
                string query2 = "select * from Chuyen ch,Tuyen t,Tai_xe tx , Xe x, LoaiXe lx Where ch.Tuyen_ID_Tuyen = t.ID_Tuyen and t.ID_Tuyen = @id and year(ch.Gio_khoi_hanh) = @year and month(ch.Gio_khoi_hanh) = @month and day(ch.Gio_khoi_hanh) = @day  and tx.ID_TaiXe = ch.Tai_xe_ID_TaiXe and x.XeID = ch.Xe_XeID and x.LoaiXe_ID_LoaiXe = lx.ID_LoaiXe";
                DataTable info = provider.Select(CommandType.Text, query2,
                                                new SqlParameter { ParameterName = "@id", Value = id },
                                                new SqlParameter { ParameterName = "@year", Value = year },
                                                new SqlParameter { ParameterName = "@month", Value = month },
                                                new SqlParameter { ParameterName = "@day", Value = day });
                foreach(DataRow item in info.Rows)
                {
                    string id_Chuyen = item["ID_Chuyen"].ToString();
                    string gio_Khoi_Hanh = item["Gio_Khoi_Hanh"].ToString();
                    string xe_XeID = item["TenLoai"].ToString();
                    string tai_xe_ID_TaiXe = item["TenTaiXe"].ToString();
                    int khoangCach = int.Parse(item["KhoangCach"].ToString());
                    string thoiGianChay = item["ThoiGianChay"].ToString();
                    ThongTinChuyen u = new ThongTinChuyen(id_Chuyen, gio_Khoi_Hanh, xe_XeID, tai_xe_ID_TaiXe, khoangCach, thoiGianChay);
                    ls.Add(u);
                }
                return ls;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public List<string> LoadIdChuyen(string diemBatDau, string diemDen, int year, int month, int day)
        {
            List<string> ls = new List<string>();
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT t.ID_Tuyen FROM Tram tr, Tuyen t, Tram tr1 WHERE t.Tram_ID_Tram1 = tr.ID_Tram and t.Tram_ID_Tram = tr1.ID_Tram and tr.Dia_Diem = @diemBatDau and tr1.Dia_Diem = @diemDen";
                DataTable id_Tuyen = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@diemBatDau", Value = diemBatDau },
                                                new SqlParameter { ParameterName = "@diemDen", Value = diemDen });
                string id = id_Tuyen.Rows[0][0].ToString();
                string query2 = "select ch.ID_Chuyen from Chuyen ch,Tuyen t,Tai_xe tx , Xe x Where ch.Tuyen_ID_Tuyen = t.ID_Tuyen and t.ID_Tuyen = @id and year(ch.Gio_khoi_hanh) = @year and month(ch.Gio_khoi_hanh) = @month and day(ch.Gio_khoi_hanh) = @day  and tx.ID_TaiXe = ch.Tai_xe_ID_TaiXe and x.XeID = ch.Xe_XeID";
                DataTable info = provider.Select(CommandType.Text, query2,
                                                new SqlParameter { ParameterName = "@id", Value = id },
                                                new SqlParameter { ParameterName = "@year", Value = year },
                                                new SqlParameter { ParameterName = "@month", Value = month },
                                                new SqlParameter { ParameterName = "@day", Value = day });
                foreach (DataRow item in info.Rows)
                {
                    string id_Chuyen = item["ID_Chuyen"].ToString();
                    ls.Add(id_Chuyen);
                }
                return ls;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }
        
        public string LoadSoChoDaDat(string idChuyen)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT count(Ghe_ID_Ghe) FROM Ve WHERE Chuyen_ID_Chuyen = @id";
                DataTable info = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@id", Value = idChuyen });
                return info.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }
        
        public ThongTinKhachHang LoadThongTinKhachHang(string sdt)
        {
            Provider provider = new Provider();
            ThongTinKhachHang kh = new ThongTinKhachHang();
            try
            {
                provider.Connect();
                string query = "SELECT kh.ID_KhachHang,kh.HoTen,kh.Loai,kh.Email,kh.DienThoai FROM KhachHang kh WHERE kh.DienThoai = @sdt";
                DataTable info = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@sdt", Value = sdt });
                if(info.Rows.Count > 0)
                {
                    kh.Id = int.Parse(info.Rows[0][0].ToString());
                    kh.TenKhachHang = info.Rows[0][1].ToString();
                    kh.LoaiKhachHang = info.Rows[0][2].ToString();
                    kh.Email = info.Rows[0][3].ToString();
                    kh.Sdt = info.Rows[0][4].ToString();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return kh;
        }

        public DataTable LoadSoDongSoCot(string idChuyen)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT MAX(Cot),MAX(Dong) FROM Ghe WHERE Xe_XeID IN (SELECT ch.Xe_XeID  FROM Chuyen ch WHERE ch.ID_Chuyen = @id)";
                DataTable info = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@id", Value = idChuyen });
                return info;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public DataTable LoadTinhTrangGhe(string idChuyen)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT Ghe_ID_Ghe,tinhtrang FROM Ve WHERE Chuyen_ID_Chuyen = @id";
                DataTable info = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@id", Value = idChuyen });
                return info;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public string LoadIdXe(string idChuyen)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "SELECT Xe_XeID FROM Chuyen WHERE ID_Chuyen = @id";
                DataTable info = provider.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@id", Value = idChuyen });
                return info.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public bool ThemVe(Ve info)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "INSERT INTO Ve(Ghe_ID_Ghe,Chuyen_ID_Chuyen,TinhTrang,GiaTien,KhachHang_ID_KhachHang,NgayXuatVe,GhiChu) VALUES(@idGhe,@idChuyen,@tinhTrang,@giaTien,@idKh,@ngayXuatVe,@ghiChu)";
                if (provider.ExcuteNoneQuery(CommandType.Text,query,
                                            new SqlParameter { ParameterName = "@idGhe", Value = info.Ghe_ID_Ghe },
                                            new SqlParameter { ParameterName = "@idChuyen", Value = info.Chuyen_ID_Chuyen },
                                            new SqlParameter { ParameterName = "@tinhTrang", Value = info.TinhTrang },
                                            new SqlParameter { ParameterName = "@giaTien", Value = info.GiaTien },
                                            new SqlParameter { ParameterName = "@idKh", Value = info.KhachHang_ID_KhachHang },
                                            new SqlParameter { ParameterName = "@ngayXuatVe", Value = info.NgayXuatVe },
                                            new SqlParameter { ParameterName = "@ghiChu", Value = info.GhiChu }) > 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public bool ThemKhachHang(ThongTinKhachHang kh)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "INSERT INTO KhachHang(HoTen,DienThoai,Email,Loai) VALUES(@hoTen,@dienThoai,@email,@loai)";
                if (provider.ExcuteNoneQuery(CommandType.Text, query,
                                            new SqlParameter { ParameterName = "@hoTen", Value = kh.TenKhachHang },
                                            new SqlParameter { ParameterName = "@dienThoai", Value = kh.Sdt },
                                            new SqlParameter { ParameterName = "@email", Value = kh.Email },
                                            new SqlParameter { ParameterName = "@loai", Value = kh.LoaiKhachHang }) > 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public string LayIDVeGanNhat()
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "Select identity(int, 1, 1) as idenCol,ID_Ve into #temptbl from Ve go select top 1 ID_Ve from #temptbl order by idenCol desc";
                DataTable info = provider.SelectNonPara(CommandType.Text, query);
                string query2 = "drop table #temptbl";
                DataTable delete = provider.SelectNonPara(CommandType.Text, query2);
                return info.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }

        public string LayIDKhachGanNhat()
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "select Max(ID_KhachHang) from KhachHang";
                DataTable info = provider.SelectNonPara(CommandType.Text, query);
                return info.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
        }
        
        public bool HuyVe(string idGhe,string sdt)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "delete Ve where Ghe_ID_Ghe = @idGhe and KhachHang_ID_KhachHang in (select ID_KhachHang from KhachHang where DienThoai = @dt)";
                provider.Connect();
                if (provider.ExcuteNoneQuery(CommandType.Text, query,
                                            new SqlParameter { ParameterName = "@dt", Value = sdt },
                                            new SqlParameter { ParameterName = "@idGhe", Value = idGhe }) > 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            
        }
    }

}

/*
 * List<string> ls = new List<string>();
            Provider provider = new Provider();
            try
            {
                provider.Connect();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
*/