using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDTO;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
        }

        private CustomerDAO() { }

        //Xem
        public List<user> View()
        {
            List<user> users = new List<user>();
            try
            {
                string query = "select * from Customers";
                DataTable dt = DataProvider.Instance.Select(CommandType.Text, query);
                foreach (DataRow item in dt.Rows)
                {
                    string id = item["CustomerID"].ToString();
                    string cpnName = item["CompanyName"].ToString();
                    string ctcName = item["ContactName"].ToString();
                    string ctcTitle = item["ContactTitle"].ToString();
                    string addr = item["Address"].ToString();
                    string city = item["City"].ToString();
                    string region = item["Region"] == null ? null : item["Region"].ToString();
                    string posCode = item["PostalCode"] == null ? null : item["PostalCode"].ToString();
                    string country = item["Country"].ToString();
                    string phone = item["Phone"].ToString();
                    string fax = item["Fax"] == null ? null : item["Fax"].ToString();

                    user newU = new user(id, cpnName, ctcName, ctcTitle, addr, city, region, posCode, country, phone, fax);
                    users.Add(newU);
                }
                return users;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Sua
        public bool Edit(string id, user cts)
        {
            List<user> users = new List<user>();
            try
            {
                string query = "UPDATE Customers SET CompanyName = @CompanyName , ContactName = @ContactName , ContactTitle = @ContactTitle , Address = @Address , City = @City , Region = @Region , PostalCode = @PostalCode , Country = @Country , Phone = @Phone , Fax = @Fax WHERE CustomerID = @oldid";
                object[] para = new object[] { cts.CompanyName, cts.ContactName, cts.ContactTitle, cts.Address, cts.City, cts.Region, cts.PostalCode, cts.Country, cts.Phone, cts.Fax, id };
                if (DataProvider.Instance.ExecuteNonQuery2(query, para) > 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DataProvider.Instance.disconnect();
            }
        }

        public bool Delete(string id)
        {
            List<user> users = new List<user>();
            try
            {
                string query = "DELETE FROM Customers WHERE CustomerID = @id";
                object[] para = new object[] { id };
                if (DataProvider.Instance.ExecuteNonQuery2(query, para) > 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DataProvider.Instance.disconnect();
            }
        }
    }
}
