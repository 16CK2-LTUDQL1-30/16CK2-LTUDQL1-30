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
}
