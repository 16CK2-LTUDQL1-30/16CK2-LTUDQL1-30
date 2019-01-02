using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

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
    }
}
