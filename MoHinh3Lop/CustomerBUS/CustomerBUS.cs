using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CustomerDAO;

namespace CustomerBUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;

        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerBUS();
                return instance;
            }
        }

        private CustomerBUS() { }
        public void View(DataTable data)
        {

        }
    }


}
