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
                if(instance == null)
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
                foreach(DataRow item in dt.Rows)
                {
                    string tenXe = item["TenXe"].ToString();
                    string tenLoai = item["TenLoai"].ToString();
                    string soDangKy = item["So_dang_ky"].ToString();
                    string tenTaiXe = item["TenTaiXe"].ToString();
                    int khoangCach = Convert.ToInt32( item["KhoangCach"]);
                    //DateTime? kiểm tra null
                    //nếu thoiGianChay = empty thì trả ra null còn ngược lại trả ra datetime
                    DateTime? thoiGianChay = item["Gio_khoi_hanh"].ToString() == string.Empty ? null : (DateTime?)item["Gio_khoi_hanh"];
                    string bangLai = item["BangLai"].ToString();

                    User newUser = new User(tenXe, tenLoai, soDangKy, tenTaiXe, bangLai,khoangCach, thoiGianChay);
                    users.Add(newUser);
                }
                return users;
            }
            catch(SqlException ex)
            { throw ex; }
        }
    }
}
