using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BUS;

namespace GUI
{
    public partial class frmQuanLyVeXe : Form
    {
        public frmQuanLyVeXe()
        {
            InitializeComponent();
        }

        private void frmQuanLyVeXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();//thoát chương trình
            }
        }

        private void dtgvDSChuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbDSChuyenXe_Enter(object sender, EventArgs e)
        {
            UserBUS.Instance.Load_DSChuyen(dtgvDSChuyen);
        }

        private void frmQuanLyVeXe_Load(object sender, EventArgs e)
        {
            cbbTuyenXe.DataSource = UserBUS.Instance.Load_Tuyen();
            List<string> lst = new List<string> { "thường", "VIP" };
            cbbLoaiKH.DataSource = lst;
        }

        private void cbbTuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cbbTuyenXe.SelectedItem.ToString();
            string[] arrListStr = i.Split('-');
            cbbDiaDiem.DataSource = UserBUS.Instance.Load_DiaDiem(arrListStr[0], arrListStr[1]);
        }

        private void cbbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cbbDiaDiem.SelectedItem.ToString();
            string[] arrListStr = i.Split('-');
            DateTime dt = dtpNgayGio.Value;
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            UserBUS.Instance.Load_ThongTin(dtgvThongTin, arrListStr[0], arrListStr[1], year, month, day);
            cbbChonChuyen.DataSource = UserBUS.Instance.LoadIdTuyen(arrListStr[0], arrListStr[1], year, month, day);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string sdt = tbSoDT.Text;
            if (UserBUS.Instance.LoadTenKhachHang(sdt) != "false")
            {
                tbHoTenVe.Text = UserBUS.Instance.LoadTenKhachHang(sdt);
                tbEmail.Text = UserBUS.Instance.LoadEmailKhachHang(sdt);
                cbbLoaiKH.Text = UserBUS.Instance.LoadLoaiKhachHang(sdt);
                cbbLoaiKH.Enabled = false;

            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
        }

        private void cbbChonChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbSoDo.Controls.Clear();
            tbViTriGhe.Text = String.Empty;
            string idChuyen = cbbChonChuyen.SelectedItem.ToString();
            tbSoChoConLai.Text = UserBUS.Instance.LoadSoChoDaDat(idChuyen);
            DataTable Ghe = UserBUS.Instance.LoadSoDongSoCot(idChuyen);
            DataTable bangTinhTrang = UserBUS.Instance.LoadTinhTrangGhe(idChuyen);
            string xe = UserBUS.Instance.LoadIdXe(idChuyen);
            if (Ghe.Rows.Count > 0)
            {
                int cot = int.Parse(Ghe.Rows[0][0].ToString());
                int dong = int.Parse(Ghe.Rows[0][1].ToString());
                //Tạo sơ đồ
                int index = 1;
                int staticWidth = 50;
                int staticHeight = 50;
                for (int j = 1; j <= dong; j++)
                {
                    for (int i = 1; i <= cot; i++)
                    {
                        if (index < 31)
                        {
                            Button btn = new Button();
                            foreach (DataRow row in bangTinhTrang.Rows)
                            {
                                int sub = int.Parse(row["Ghe_ID_Ghe"].ToString().Substring(5));
                                string tinhTrang = row["tinhtrang"].ToString();
                                if (sub == index)
                                {
                                    if (tinhTrang.Equals("thanh toan"))
                                    {
                                        btn.BackColor = Color.Green;
                                        break;
                                    }
                                    else if (tinhTrang.Equals("dat truoc "))
                                    {
                                        btn.BackColor = Color.Red;
                                        break;
                                    }
                                }
                            }
                            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
                            btn.Width = staticWidth;
                            btn.Height = staticHeight;
                            btn.Left = j * staticWidth;
                            btn.Top = i * staticHeight;
                            btn.Text = index.ToString();
                            int tempI = index;
                            string tempJ = tempI.ToString();
                            btn.Click += (o, ev) =>
                            {
                                string color = btn.BackColor.ToString();
                                if (color == "Color [Red]")
                                {
                                    string idXe = UserBUS.Instance.LoadIdXe(idChuyen).ToString().Substring(0, 4);
                                    int viTri = tempI;
                                    string idGhe;
                                    if (viTri / 10 == 0)
                                    {
                                        idGhe = idXe + "G0" + viTri.ToString();
                                    }
                                    else
                                    {
                                        idGhe = idXe + "G" + viTri.ToString();
                                    }
                                    Form2 frm2 = new Form2();
                                    frm2.Result = idGhe;
                                    frm2.Show();
                                }
                                else if (color == "Color [Green]")
                                {
                                    MessageBox.Show("đã thanh toán");
                                }
                                else
                                {
                                    tbViTriGhe.Text = tempJ;
                                }
                            };
                            index++;
                            gbSoDo.Controls.Add(btn);
                        }
                    }
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            string tinhTrang = "dat truoc"; //*
            string idChuyen = cbbChonChuyen.SelectedItem.ToString();
            string idXe = UserBUS.Instance.LoadIdXe(idChuyen).ToString().Substring(0, 4);
            int viTri;
            if (String.IsNullOrEmpty(tbViTriGhe.Text))
            {
                viTri = 0;
            }
            else
            {
                viTri = int.Parse(tbViTriGhe.Text);
            }
            string idGhe;
            if (viTri / 10 == 0)
            {
                idGhe = idXe + "G0" + viTri.ToString();
            }
            else
            {
                idGhe = idXe + "G" + viTri.ToString();
            }
            float giaTien = float.Parse(tbGiaTien.Text.ToString()); //*
            string ghiChu = tbGhiChu.Text.ToString(); //*
            string sdt = tbSoDT.Text.ToString(); //*
            string hoTen = tbHoTenVe.Text.ToString(); //*
            string email = tbEmail.Text.ToString(); //*
            string loai = cbbLoaiKH.SelectedItem.ToString(); //*
            DateTime dt = dtpXuatVe.Value;
            if (UserBUS.Instance.LoadTenKhachHang(sdt) != "false")
            {
                int idKh = int.Parse(UserBUS.Instance.LoadIdKhachHang(sdt).ToString());
                if (viTri > 0)
                {
                    if (UserBUS.Instance.ThemVe("No", idGhe, idChuyen, tinhTrang, giaTien, idKh, dt, ghiChu))
                    {
                        MessageBox.Show("Đặt thành công");
                        cbbChonChuyen_SelectedIndexChanged(sender, e);
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                        cbbLoaiKH.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Đặt thất bại");
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                        cbbLoaiKH.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn chỗ");
                }
            }
            else
            {
                int idKh = int.Parse(UserBUS.Instance.LayIDKhachGanNhat().ToString()) + 1;
                if (viTri > 0)
                {
                    if (UserBUS.Instance.ThemKhachHang(1, hoTen, sdt, email, loai) == true && UserBUS.Instance.ThemVe("No", idGhe, idChuyen, tinhTrang, giaTien, idKh, dt, ghiChu) == true)
                    {
                        cbbChonChuyen_SelectedIndexChanged(sender, e);
                        MessageBox.Show("Bán thành công vé và khách hàng mới");
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Bán thất bại");
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn chỗ");
                }
            }
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            string tinhTrang = "thanh toan"; //*
            string idChuyen = cbbChonChuyen.SelectedItem.ToString();
            string idXe = UserBUS.Instance.LoadIdXe(idChuyen).ToString().Substring(0, 4);
            int viTri;
            if (String.IsNullOrEmpty(tbViTriGhe.Text))
            {
                viTri = 0;
            }
            else
            {
                viTri = int.Parse(tbViTriGhe.Text);
            }
            string idGhe;
            if (viTri / 10 == 0)
            {
                idGhe = idXe + "G0" + viTri.ToString();
            }
            else
            {
                idGhe = idXe + "G" + viTri.ToString();
            }
            float giaTien = float.Parse(tbGiaTien.Text.ToString()); //*
            string ghiChu = tbGhiChu.Text.ToString(); //*
            string sdt = tbSoDT.Text.ToString(); //*
            string hoTen = tbHoTenVe.Text.ToString(); //*
            string email = tbEmail.Text.ToString(); //*
            string loai = cbbLoaiKH.SelectedItem.ToString(); //*
            DateTime dt = dtpXuatVe.Value;
            if (UserBUS.Instance.LoadTenKhachHang(sdt) != "false")
            {
                int idKh = int.Parse(UserBUS.Instance.LoadIdKhachHang(sdt).ToString());
                if (viTri > 0)
                {
                    if (UserBUS.Instance.ThemVe("No", idGhe, idChuyen, tinhTrang, giaTien, idKh, dt, ghiChu))
                    {
                        MessageBox.Show("Đặt thành công");
                        cbbChonChuyen_SelectedIndexChanged(sender, e);
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                        cbbLoaiKH.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Đặt thất bại");
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                        cbbLoaiKH.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn chỗ");
                }
            }
            else
            {
                int idKh = int.Parse(UserBUS.Instance.LoadIdKhachHang(sdt).ToString()) + 1;
                if (viTri > 0)
                {
                    if (UserBUS.Instance.ThemKhachHang(2, hoTen, sdt, email, loai) == true && UserBUS.Instance.ThemVe("No", idGhe, idChuyen, tinhTrang, giaTien, idKh, dt, ghiChu) == true)
                    {
                        cbbChonChuyen_SelectedIndexChanged(sender, e);
                        MessageBox.Show("Bán thành công vé và khách hàng mới");
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Bán thất bại");
                        tbSoDT.Text = String.Empty;
                        tbHoTenVe.Text = String.Empty;
                        tbGhiChu.Text = String.Empty;
                        tbGiaTien.Text = String.Empty;
                        tbEmail.Text = String.Empty;
                        tbViTriGhe.Text = String.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn chỗ");
                }
            }
        }
    }
}
        

